using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace CalypsoMaint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START OF CALYPSO MAINTENANCE PROGRAM");

            DataClassesDataContext db = new DataClassesDataContext();

            var ConfigSets = from cs in db.ConfigSets
                             where cs.Status == "ACTIVE"
                             select cs;

            foreach (var cs in ConfigSets)
            {
                Console.WriteLine("Found config '" + cs.Name + "' (" + cs.ConfigSetId + ") for path " + cs.BasePath + "...");

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                /* Rebuild track list */
                Console.WriteLine("Building file list for ConfigSetId " + cs.ConfigSetId);
                int NewFileCount = 0;
                int UpdatedFileCount = 0;
                int DeletedFileCount = 0;
                int ErrorCount = 0;

                foreach (string file in Directory.EnumerateFiles(cs.BasePath, "*.*", SearchOption.AllDirectories))
                {
                    Track t;
                    bool NewTrack = true;

                    /* Find existing track record, if found, update, else insert */
                    var FindTrack = from ft in db.Tracks
                                         where ft.Path == file
                                         select ft;

                    if (FindTrack.FirstOrDefault() != null)
                    {
                        t = FindTrack.FirstOrDefault();
                        UpdatedFileCount++;
                        NewTrack = false;
                    }
                    else
                    {
                        t = new Track();
                        //Console.WriteLine("NEW TRACK: " + file);
                        NewFileCount++;
                    }

                    /* Basic File info */
                    t.ConfigSetId = cs.ConfigSetId;
                    t.FileName = Path.GetFileNameWithoutExtension(file).Substring(0, Math.Min(500, Path.GetFileNameWithoutExtension(file).Length));
                    t.Path = Path.GetFullPath(file).Substring(0, Math.Min(500, Path.GetFullPath(file).Length));
                    var WebPath = Path.GetFullPath(file).Replace(cs.BasePath, cs.WebPath).Replace('\\', '/');
                    t.WebPath = WebPath.Substring(0, Math.Min(500, WebPath.Length));
                    FileInfo fi = new FileInfo(file);
                    t.FileSize = fi.Length;
                    t.FileType = Path.GetExtension(file).Replace(".", "").Substring(0, Math.Min(10, Path.GetExtension(file).Replace(".", "").Length)).ToLower();
                    t.FileStatus = "OK";
                    t.LastUpdated = DateTime.Now;
                    if (t.FileType.Equals("flac") || t.FileType.Equals("wav") || t.FileType.Equals("shn") || t.FileType.Equals("ape"))
                    {
                        t.Lossless = "Lossless";
                    }
                    else
                    {
                        t.Lossless = "Lossy";
                    }

                    /* ID3 Tags, bitrates, et al */
                    if (t.FileType.Equals("mp3") || t.FileType.Equals("flac") || t.FileType.Equals("ogg") || t.FileType.Equals("m4a") || 
                        t.FileType.Equals("mp2") || t.FileType.Equals("mp1") || t.FileType.Equals("m2a") || t.FileType.Equals("aac") ||
                        t.FileType.Equals("wma"))
                    {
                        try
                        {
                            TagLib.File f = TagLib.File.Create(file);
                            if (f.Tag.AlbumArtists.Length > 0 && f.Tag.AlbumArtists[0] != null)
                                t.Artist = f.Tag.AlbumArtists[0].Substring(0, Math.Min(100, f.Tag.AlbumArtists[0].Length));
                            if (f.Tag.Title != null)
                                t.Title = f.Tag.Title.Substring(0, Math.Min(100, f.Tag.Title.Length));
                            if (f.Tag.Album != null)
                                t.Album = f.Tag.Album.Substring(0, Math.Min(100, f.Tag.Album.Length));
                            t.Year = Int32.Parse(f.Tag.Year.ToString());
                            if (f.Tag.Genres.Length > 0 && f.Tag.Genres[0] != null)
                                t.Genre = f.Tag.Genres[0].Substring(0, Math.Min(100, f.Tag.Genres[0].Length));
                            t.TrackNumber = (int) f.Tag.TrackCount;
                            t.Bitrate = f.Properties.AudioBitrate;
                            if (f.Properties.Duration != null)
                                t.DurationSec = (int) f.Properties.Duration.TotalSeconds;
                            t.BPM = (int) f.Tag.BeatsPerMinute;
                            if (!double.IsNaN(f.Tag.ReplayGainTrackGain))
                                t.ReplayGainTrackGain = f.Tag.ReplayGainTrackGain * 1;
                            if (!double.IsNaN(f.Tag.ReplayGainTrackPeak))
                                t.ReplayGainTrackPeak = f.Tag.ReplayGainTrackPeak * 1;
                            if (f.Tag.Comment != null)
                                t.Notes = f.Tag.Comment.Substring(0, Math.Min(500, f.Tag.Comment.Length));
                            f.Dispose();
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("  Error: " + e.Message + file);
                            t.FileStatus = "ERROR";
                            t.Notes = e.Message;
                            ErrorCount++;
                        }
                    }

                    /* BPM Analysis */

                    /* Generate Wave Image */

                    if (NewTrack)
                        db.Tracks.InsertOnSubmit(t);
                }

                db.SubmitChanges();
                Console.WriteLine("  Found " + NewFileCount.ToString() + " new file(s) to insert, updated " + UpdatedFileCount.ToString() + " file(s)");

                /* flag track as deleted if it can't be found on the file system */
                Console.WriteLine("Marking deleted tracks from database for ConfigSetId " + cs.ConfigSetId);
                var TracksToDelete = from t in db.Tracks
                                     where t.ConfigSetId == cs.ConfigSetId
                                     select t;

                foreach (var t in TracksToDelete)
                {
                    if (!File.Exists(t.Path))
                    {
                        t.FileStatus = "DELETED";
                        DeletedFileCount++;
                    }                    
                }

                db.SubmitChanges();
                Console.WriteLine("  Marked " + DeletedFileCount.ToString() + " track(s) for removal");

                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime);
                cs.LastLoaded = DateTime.Now;
                cs.FileCount = UpdatedFileCount + NewFileCount - DeletedFileCount;
                cs.ErrorCount = ErrorCount;
                cs.TimeTakenToLoad = (long) ts.TotalSeconds;

                db.SubmitChanges();

                Console.WriteLine("  Done");
            }

            Console.WriteLine("Calypso Maintenance Complete!");
            Console.ReadLine();
        }
    }
}
