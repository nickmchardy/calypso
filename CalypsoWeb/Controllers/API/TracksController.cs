using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CalypsoWeb.Controllers
{
    public class TracksController : ApiController
    {
        // GET api/tracks/search/term
        [HttpGet]
        [ActionName("Search")]
        public IQueryable<Track> GetSearch(String id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var Tracks = from t in db.Tracks
                         join cs in db.ConfigSets on t.ConfigSetId equals cs.ConfigSetId
                         where cs.Status.Equals("ACTIVE") && (t.Album.Contains(id) || t.Artist.Contains(id) || t.Title.Contains(id))
                         select t;

            return Tracks;
        }

        // GET api/tracks/id/1
        [HttpGet]
        [ActionName("Detail")]
        public CalypsoWeb.Track GetDetail(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var Tracks = from t in db.Tracks
                         where t.TrackId == id
                         select t;

            return Tracks.FirstOrDefault();
        }
    }
}
