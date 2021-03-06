﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalypsoMaint
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Calypso")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertConfigSet(ConfigSet instance);
    partial void UpdateConfigSet(ConfigSet instance);
    partial void DeleteConfigSet(ConfigSet instance);
    partial void InsertTrack(Track instance);
    partial void UpdateTrack(Track instance);
    partial void DeleteTrack(Track instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::CalypsoMaint.Properties.Settings.Default.CalypsoConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ConfigSet> ConfigSets
		{
			get
			{
				return this.GetTable<ConfigSet>();
			}
		}
		
		public System.Data.Linq.Table<Track> Tracks
		{
			get
			{
				return this.GetTable<Track>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ConfigSet")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class ConfigSet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ConfigSetId;
		
		private string _Name;
		
		private string _Description;
		
		private string _Status;
		
		private string _BasePath;
		
		private string _WebPath;
		
		private System.Nullable<System.DateTime> _LastLoaded;
		
		private long _TimeTakenToLoad;
		
		private long _FileCount;
		
		private long _ErrorCount;
		
		private EntitySet<Track> _Tracks;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnConfigSetIdChanging(int value);
    partial void OnConfigSetIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnBasePathChanging(string value);
    partial void OnBasePathChanged();
    partial void OnWebPathChanging(string value);
    partial void OnWebPathChanged();
    partial void OnLastLoadedChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoadedChanged();
    partial void OnTimeTakenToLoadChanging(long value);
    partial void OnTimeTakenToLoadChanged();
    partial void OnFileCountChanging(long value);
    partial void OnFileCountChanged();
    partial void OnErrorCountChanging(long value);
    partial void OnErrorCountChanged();
    #endregion
		
		public ConfigSet()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfigSetId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int ConfigSetId
		{
			get
			{
				return this._ConfigSetId;
			}
			set
			{
				if ((this._ConfigSetId != value))
				{
					this.OnConfigSetIdChanging(value);
					this.SendPropertyChanging();
					this._ConfigSetId = value;
					this.SendPropertyChanged("ConfigSetId");
					this.OnConfigSetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BasePath", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string BasePath
		{
			get
			{
				return this._BasePath;
			}
			set
			{
				if ((this._BasePath != value))
				{
					this.OnBasePathChanging(value);
					this.SendPropertyChanging();
					this._BasePath = value;
					this.SendPropertyChanged("BasePath");
					this.OnBasePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WebPath", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string WebPath
		{
			get
			{
				return this._WebPath;
			}
			set
			{
				if ((this._WebPath != value))
				{
					this.OnWebPathChanging(value);
					this.SendPropertyChanging();
					this._WebPath = value;
					this.SendPropertyChanged("WebPath");
					this.OnWebPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLoaded", DbType="DateTime")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public System.Nullable<System.DateTime> LastLoaded
		{
			get
			{
				return this._LastLoaded;
			}
			set
			{
				if ((this._LastLoaded != value))
				{
					this.OnLastLoadedChanging(value);
					this.SendPropertyChanging();
					this._LastLoaded = value;
					this.SendPropertyChanged("LastLoaded");
					this.OnLastLoadedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeTakenToLoad", DbType="BigInt NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public long TimeTakenToLoad
		{
			get
			{
				return this._TimeTakenToLoad;
			}
			set
			{
				if ((this._TimeTakenToLoad != value))
				{
					this.OnTimeTakenToLoadChanging(value);
					this.SendPropertyChanging();
					this._TimeTakenToLoad = value;
					this.SendPropertyChanged("TimeTakenToLoad");
					this.OnTimeTakenToLoadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileCount", DbType="BigInt NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public long FileCount
		{
			get
			{
				return this._FileCount;
			}
			set
			{
				if ((this._FileCount != value))
				{
					this.OnFileCountChanging(value);
					this.SendPropertyChanging();
					this._FileCount = value;
					this.SendPropertyChanged("FileCount");
					this.OnFileCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorCount", DbType="BigInt NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
		public long ErrorCount
		{
			get
			{
				return this._ErrorCount;
			}
			set
			{
				if ((this._ErrorCount != value))
				{
					this.OnErrorCountChanging(value);
					this.SendPropertyChanging();
					this._ErrorCount = value;
					this.SendPropertyChanged("ErrorCount");
					this.OnErrorCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ConfigSet_Track", Storage="_Tracks", ThisKey="ConfigSetId", OtherKey="ConfigSetId")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=11, EmitDefaultValue=false)]
		public EntitySet<Track> Tracks
		{
			get
			{
				if ((this.serializing 
							&& (this._Tracks.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Tracks;
			}
			set
			{
				this._Tracks.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Tracks(Track entity)
		{
			this.SendPropertyChanging();
			entity.ConfigSet = this;
		}
		
		private void detach_Tracks(Track entity)
		{
			this.SendPropertyChanging();
			entity.ConfigSet = null;
		}
		
		private void Initialize()
		{
			this._Tracks = new EntitySet<Track>(new Action<Track>(this.attach_Tracks), new Action<Track>(this.detach_Tracks));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Track")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Track : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TrackId;
		
		private string _Path;
		
		private string _WebPath;
		
		private string _FileName;
		
		private long _FileSize;
		
		private string _FileType;
		
		private int _ConfigSetId;
		
		private System.DateTime _LastUpdated;
		
		private string _FileStatus;
		
		private string _Notes;
		
		private string _Artist;
		
		private string _Title;
		
		private string _Album;
		
		private System.Nullable<int> _Year;
		
		private System.Nullable<int> _TrackNumber;
		
		private string _Genre;
		
		private System.Nullable<int> _BPM;
		
		private System.Nullable<int> _BPMAccuracyPct;
		
		private System.Nullable<long> _DurationSec;
		
		private System.Nullable<int> _Bitrate;
		
		private string _Lossless;
		
		private double _ReplayGainTrackGain;
		
		private double _ReplayGainTrackPeak;
		
		private EntityRef<ConfigSet> _ConfigSet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrackIdChanging(int value);
    partial void OnTrackIdChanged();
    partial void OnPathChanging(string value);
    partial void OnPathChanged();
    partial void OnWebPathChanging(string value);
    partial void OnWebPathChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnFileSizeChanging(long value);
    partial void OnFileSizeChanged();
    partial void OnFileTypeChanging(string value);
    partial void OnFileTypeChanged();
    partial void OnConfigSetIdChanging(int value);
    partial void OnConfigSetIdChanged();
    partial void OnLastUpdatedChanging(System.DateTime value);
    partial void OnLastUpdatedChanged();
    partial void OnFileStatusChanging(string value);
    partial void OnFileStatusChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnArtistChanging(string value);
    partial void OnArtistChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnAlbumChanging(string value);
    partial void OnAlbumChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    partial void OnTrackNumberChanging(System.Nullable<int> value);
    partial void OnTrackNumberChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnBPMChanging(System.Nullable<int> value);
    partial void OnBPMChanged();
    partial void OnBPMAccuracyPctChanging(System.Nullable<int> value);
    partial void OnBPMAccuracyPctChanged();
    partial void OnDurationSecChanging(System.Nullable<long> value);
    partial void OnDurationSecChanged();
    partial void OnBitrateChanging(System.Nullable<int> value);
    partial void OnBitrateChanged();
    partial void OnLosslessChanging(string value);
    partial void OnLosslessChanged();
    partial void OnReplayGainTrackGainChanging(double value);
    partial void OnReplayGainTrackGainChanged();
    partial void OnReplayGainTrackPeakChanging(double value);
    partial void OnReplayGainTrackPeakChanged();
    #endregion
		
		public Track()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int TrackId
		{
			get
			{
				return this._TrackId;
			}
			set
			{
				if ((this._TrackId != value))
				{
					this.OnTrackIdChanging(value);
					this.SendPropertyChanging();
					this._TrackId = value;
					this.SendPropertyChanged("TrackId");
					this.OnTrackIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Path", DbType="NVarChar(400) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				if ((this._Path != value))
				{
					this.OnPathChanging(value);
					this.SendPropertyChanging();
					this._Path = value;
					this.SendPropertyChanged("Path");
					this.OnPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WebPath", DbType="NVarChar(500)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string WebPath
		{
			get
			{
				return this._WebPath;
			}
			set
			{
				if ((this._WebPath != value))
				{
					this.OnWebPathChanging(value);
					this.SendPropertyChanging();
					this._WebPath = value;
					this.SendPropertyChanged("WebPath");
					this.OnWebPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileSize", DbType="BigInt NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public long FileSize
		{
			get
			{
				return this._FileSize;
			}
			set
			{
				if ((this._FileSize != value))
				{
					this.OnFileSizeChanging(value);
					this.SendPropertyChanging();
					this._FileSize = value;
					this.SendPropertyChanged("FileSize");
					this.OnFileSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileType", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string FileType
		{
			get
			{
				return this._FileType;
			}
			set
			{
				if ((this._FileType != value))
				{
					this.OnFileTypeChanging(value);
					this.SendPropertyChanging();
					this._FileType = value;
					this.SendPropertyChanged("FileType");
					this.OnFileTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfigSetId", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public int ConfigSetId
		{
			get
			{
				return this._ConfigSetId;
			}
			set
			{
				if ((this._ConfigSetId != value))
				{
					if (this._ConfigSet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnConfigSetIdChanging(value);
					this.SendPropertyChanging();
					this._ConfigSetId = value;
					this.SendPropertyChanged("ConfigSetId");
					this.OnConfigSetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdated", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public System.DateTime LastUpdated
		{
			get
			{
				return this._LastUpdated;
			}
			set
			{
				if ((this._LastUpdated != value))
				{
					this.OnLastUpdatedChanging(value);
					this.SendPropertyChanging();
					this._LastUpdated = value;
					this.SendPropertyChanged("LastUpdated");
					this.OnLastUpdatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileStatus", DbType="NVarChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public string FileStatus
		{
			get
			{
				return this._FileStatus;
			}
			set
			{
				if ((this._FileStatus != value))
				{
					this.OnFileStatusChanging(value);
					this.SendPropertyChanging();
					this._FileStatus = value;
					this.SendPropertyChanged("FileStatus");
					this.OnFileStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NVarChar(500)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Artist", DbType="NVarChar(100)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=11)]
		public string Artist
		{
			get
			{
				return this._Artist;
			}
			set
			{
				if ((this._Artist != value))
				{
					this.OnArtistChanging(value);
					this.SendPropertyChanging();
					this._Artist = value;
					this.SendPropertyChanged("Artist");
					this.OnArtistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(100)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=12)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Album", DbType="NVarChar(100)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=13)]
		public string Album
		{
			get
			{
				return this._Album;
			}
			set
			{
				if ((this._Album != value))
				{
					this.OnAlbumChanging(value);
					this.SendPropertyChanging();
					this._Album = value;
					this.SendPropertyChanged("Album");
					this.OnAlbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=14)]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackNumber", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=15)]
		public System.Nullable<int> TrackNumber
		{
			get
			{
				return this._TrackNumber;
			}
			set
			{
				if ((this._TrackNumber != value))
				{
					this.OnTrackNumberChanging(value);
					this.SendPropertyChanging();
					this._TrackNumber = value;
					this.SendPropertyChanged("TrackNumber");
					this.OnTrackNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(100)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=16)]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPM", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=17)]
		public System.Nullable<int> BPM
		{
			get
			{
				return this._BPM;
			}
			set
			{
				if ((this._BPM != value))
				{
					this.OnBPMChanging(value);
					this.SendPropertyChanging();
					this._BPM = value;
					this.SendPropertyChanged("BPM");
					this.OnBPMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPMAccuracyPct", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=18)]
		public System.Nullable<int> BPMAccuracyPct
		{
			get
			{
				return this._BPMAccuracyPct;
			}
			set
			{
				if ((this._BPMAccuracyPct != value))
				{
					this.OnBPMAccuracyPctChanging(value);
					this.SendPropertyChanging();
					this._BPMAccuracyPct = value;
					this.SendPropertyChanged("BPMAccuracyPct");
					this.OnBPMAccuracyPctChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DurationSec", DbType="BigInt")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=19)]
		public System.Nullable<long> DurationSec
		{
			get
			{
				return this._DurationSec;
			}
			set
			{
				if ((this._DurationSec != value))
				{
					this.OnDurationSecChanging(value);
					this.SendPropertyChanging();
					this._DurationSec = value;
					this.SendPropertyChanged("DurationSec");
					this.OnDurationSecChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bitrate", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=20)]
		public System.Nullable<int> Bitrate
		{
			get
			{
				return this._Bitrate;
			}
			set
			{
				if ((this._Bitrate != value))
				{
					this.OnBitrateChanging(value);
					this.SendPropertyChanging();
					this._Bitrate = value;
					this.SendPropertyChanged("Bitrate");
					this.OnBitrateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lossless", DbType="NVarChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=21)]
		public string Lossless
		{
			get
			{
				return this._Lossless;
			}
			set
			{
				if ((this._Lossless != value))
				{
					this.OnLosslessChanging(value);
					this.SendPropertyChanging();
					this._Lossless = value;
					this.SendPropertyChanged("Lossless");
					this.OnLosslessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReplayGainTrackGain", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=22)]
		public double ReplayGainTrackGain
		{
			get
			{
				return this._ReplayGainTrackGain;
			}
			set
			{
				if ((this._ReplayGainTrackGain != value))
				{
					this.OnReplayGainTrackGainChanging(value);
					this.SendPropertyChanging();
					this._ReplayGainTrackGain = value;
					this.SendPropertyChanged("ReplayGainTrackGain");
					this.OnReplayGainTrackGainChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReplayGainTrackPeak", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=23)]
		public double ReplayGainTrackPeak
		{
			get
			{
				return this._ReplayGainTrackPeak;
			}
			set
			{
				if ((this._ReplayGainTrackPeak != value))
				{
					this.OnReplayGainTrackPeakChanging(value);
					this.SendPropertyChanging();
					this._ReplayGainTrackPeak = value;
					this.SendPropertyChanged("ReplayGainTrackPeak");
					this.OnReplayGainTrackPeakChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ConfigSet_Track", Storage="_ConfigSet", ThisKey="ConfigSetId", OtherKey="ConfigSetId", IsForeignKey=true)]
		public ConfigSet ConfigSet
		{
			get
			{
				return this._ConfigSet.Entity;
			}
			set
			{
				ConfigSet previousValue = this._ConfigSet.Entity;
				if (((previousValue != value) 
							|| (this._ConfigSet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ConfigSet.Entity = null;
						previousValue.Tracks.Remove(this);
					}
					this._ConfigSet.Entity = value;
					if ((value != null))
					{
						value.Tracks.Add(this);
						this._ConfigSetId = value.ConfigSetId;
					}
					else
					{
						this._ConfigSetId = default(int);
					}
					this.SendPropertyChanged("ConfigSet");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._ConfigSet = default(EntityRef<ConfigSet>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
