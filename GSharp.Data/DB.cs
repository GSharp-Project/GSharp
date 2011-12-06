// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2011-12-05 20:39:32Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace GSharp.Data
{
	using System;
	using System.ComponentModel;
	using System.Data;
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class Main : DataContext
	{
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		#endregion
		
		public Main(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public Main(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
		
		public Main(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Main(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<GarminDevices> GarminDevices
		{
			get
			{
				return this.GetTable <GarminDevices>();
			}
		}
		
		public Table<Laps> Laps
		{
			get
			{
				return this.GetTable <Laps>();
			}
		}
		
		public Table<Runs> Runs
		{
			get
			{
				return this.GetTable <Runs>();
			}
		}
		
		public Table<Steps> Steps
		{
			get
			{
				return this.GetTable <Steps>();
			}
		}
		
		public Table<Workout> Workout
		{
			get
			{
				return this.GetTable <Workout>();
			}
		}
	}
	
	[Table(Name="main.GarminDevices")]
	public partial class GarminDevices : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _id;
		
		private string _name;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnIDChanged();
		
				partial void OnIDChanging(int value);
		
				partial void OnNameChanged();
		
				partial void OnNameChanging(string value);
		#endregion
		
		public GarminDevices()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="Name", DbType="TEXT", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) == false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.laps")]
	public partial class Laps
	{
		
		private System.Nullable<int> _avgCadence;
		
		private System.Nullable<int> _avgHeartRage;
		
		private System.Nullable<int> _calories;
		
		private System.Nullable<int> _endLat;
		
		private System.Nullable<int> _endLon;
		
		private System.Nullable<int> _garminUnit;
		
		private System.Nullable<int> _id;
		
		private System.Nullable<int> _index;
		
		private System.Nullable<int> _intensity;
		
		private System.Nullable<int> _maxHeartRage;
		
		private System.Nullable<float> _maxSpeed;
		
		private System.Nullable<int> _startLat;
		
		private System.Nullable<int> _startLon;
		
		private System.Nullable<int> _startTime;
		
		private System.Nullable<int> _totalDist;
		
		private System.Nullable<int> _totalTime;
		
		private System.Nullable<int> _triggerMethod;
		
		private System.Nullable<int> _type;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnAvgCadenceChanged();
		
				partial void OnAvgCadenceChanging(System.Nullable<int> value);
		
				partial void OnAvgHeartRageChanged();
		
				partial void OnAvgHeartRageChanging(System.Nullable<int> value);
		
				partial void OnCaloriesChanged();
		
				partial void OnCaloriesChanging(System.Nullable<int> value);
		
				partial void OnEndLatChanged();
		
				partial void OnEndLatChanging(System.Nullable<int> value);
		
				partial void OnEndLonChanged();
		
				partial void OnEndLonChanging(System.Nullable<int> value);
		
				partial void OnGarminUnitChanged();
		
				partial void OnGarminUnitChanging(System.Nullable<int> value);
		
				partial void OnIDChanged();
		
				partial void OnIDChanging(System.Nullable<int> value);
		
				partial void OnIndexChanged();
		
				partial void OnIndexChanging(System.Nullable<int> value);
		
				partial void OnIntensityChanged();
		
				partial void OnIntensityChanging(System.Nullable<int> value);
		
				partial void OnMaxHeartRageChanged();
		
				partial void OnMaxHeartRageChanging(System.Nullable<int> value);
		
				partial void OnMaxSpeedChanged();
		
				partial void OnMaxSpeedChanging(System.Nullable<float> value);
		
				partial void OnStartLatChanged();
		
				partial void OnStartLatChanging(System.Nullable<int> value);
		
				partial void OnStartLonChanged();
		
				partial void OnStartLonChanging(System.Nullable<int> value);
		
				partial void OnStartTimeChanged();
		
				partial void OnStartTimeChanging(System.Nullable<int> value);
		
				partial void OnTotalDistChanged();
		
				partial void OnTotalDistChanging(System.Nullable<int> value);
		
				partial void OnTotalTimeChanged();
		
				partial void OnTotalTimeChanging(System.Nullable<int> value);
		
				partial void OnTriggerMethodChanged();
		
				partial void OnTriggerMethodChanging(System.Nullable<int> value);
		
				partial void OnTypeChanged();
		
				partial void OnTypeChanging(System.Nullable<int> value);
		#endregion
		
		public Laps()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_avgCadence", Name="avg_cadence", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AvgCadence
		{
			get
			{
				return this._avgCadence;
			}
			set
			{
				if ((_avgCadence != value))
				{
					this.OnAvgCadenceChanging(value);
					this._avgCadence = value;
					this.OnAvgCadenceChanged();
				}
			}
		}
		
		[Column(Storage="_avgHeartRage", Name="avg_heart_rage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AvgHeartRage
		{
			get
			{
				return this._avgHeartRage;
			}
			set
			{
				if ((_avgHeartRage != value))
				{
					this.OnAvgHeartRageChanging(value);
					this._avgHeartRage = value;
					this.OnAvgHeartRageChanged();
				}
			}
		}
		
		[Column(Storage="_calories", Name="calories", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Calories
		{
			get
			{
				return this._calories;
			}
			set
			{
				if ((_calories != value))
				{
					this.OnCaloriesChanging(value);
					this._calories = value;
					this.OnCaloriesChanged();
				}
			}
		}
		
		[Column(Storage="_endLat", Name="end_lat", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EndLat
		{
			get
			{
				return this._endLat;
			}
			set
			{
				if ((_endLat != value))
				{
					this.OnEndLatChanging(value);
					this._endLat = value;
					this.OnEndLatChanged();
				}
			}
		}
		
		[Column(Storage="_endLon", Name="end_lon", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EndLon
		{
			get
			{
				return this._endLon;
			}
			set
			{
				if ((_endLon != value))
				{
					this.OnEndLonChanging(value);
					this._endLon = value;
					this.OnEndLonChanged();
				}
			}
		}
		
		[Column(Storage="_garminUnit", Name="garmin_unit", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> GarminUnit
		{
			get
			{
				return this._garminUnit;
			}
			set
			{
				if ((_garminUnit != value))
				{
					this.OnGarminUnitChanging(value);
					this._garminUnit = value;
					this.OnGarminUnitChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this._id = value;
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_index", Name="index", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Index
		{
			get
			{
				return this._index;
			}
			set
			{
				if ((_index != value))
				{
					this.OnIndexChanging(value);
					this._index = value;
					this.OnIndexChanged();
				}
			}
		}
		
		[Column(Storage="_intensity", Name="intensity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Intensity
		{
			get
			{
				return this._intensity;
			}
			set
			{
				if ((_intensity != value))
				{
					this.OnIntensityChanging(value);
					this._intensity = value;
					this.OnIntensityChanged();
				}
			}
		}
		
		[Column(Storage="_maxHeartRage", Name="max_heart_rage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MaxHeartRage
		{
			get
			{
				return this._maxHeartRage;
			}
			set
			{
				if ((_maxHeartRage != value))
				{
					this.OnMaxHeartRageChanging(value);
					this._maxHeartRage = value;
					this.OnMaxHeartRageChanged();
				}
			}
		}
		
		[Column(Storage="_maxSpeed", Name="max_speed", DbType="REAL", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MaxSpeed
		{
			get
			{
				return this._maxSpeed;
			}
			set
			{
				if ((_maxSpeed != value))
				{
					this.OnMaxSpeedChanging(value);
					this._maxSpeed = value;
					this.OnMaxSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_startLat", Name="start_lat", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StartLat
		{
			get
			{
				return this._startLat;
			}
			set
			{
				if ((_startLat != value))
				{
					this.OnStartLatChanging(value);
					this._startLat = value;
					this.OnStartLatChanged();
				}
			}
		}
		
		[Column(Storage="_startLon", Name="start_lon", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StartLon
		{
			get
			{
				return this._startLon;
			}
			set
			{
				if ((_startLon != value))
				{
					this.OnStartLonChanging(value);
					this._startLon = value;
					this.OnStartLonChanged();
				}
			}
		}
		
		[Column(Storage="_startTime", Name="start_time", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StartTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				if ((_startTime != value))
				{
					this.OnStartTimeChanging(value);
					this._startTime = value;
					this.OnStartTimeChanged();
				}
			}
		}
		
		[Column(Storage="_totalDist", Name="total_dist", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TotalDist
		{
			get
			{
				return this._totalDist;
			}
			set
			{
				if ((_totalDist != value))
				{
					this.OnTotalDistChanging(value);
					this._totalDist = value;
					this.OnTotalDistChanged();
				}
			}
		}
		
		[Column(Storage="_totalTime", Name="total_time", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TotalTime
		{
			get
			{
				return this._totalTime;
			}
			set
			{
				if ((_totalTime != value))
				{
					this.OnTotalTimeChanging(value);
					this._totalTime = value;
					this.OnTotalTimeChanged();
				}
			}
		}
		
		[Column(Storage="_triggerMethod", Name="trigger_method", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TriggerMethod
		{
			get
			{
				return this._triggerMethod;
			}
			set
			{
				if ((_triggerMethod != value))
				{
					this.OnTriggerMethodChanging(value);
					this._triggerMethod = value;
					this.OnTriggerMethodChanged();
				}
			}
		}
		
		[Column(Storage="_type", Name="type", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((_type != value))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}
	
	[Table(Name="main.Runs")]
	public partial class Runs : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _firstLapIndex;
		
		private System.Nullable<int> _garminDevice;
		
		private System.Nullable<int> _id;
		
		private System.Nullable<int> _lastLapIndex;
		
		private System.Nullable<int> _multiSport;
		
		private System.Nullable<int> _programType;
		
		private System.Nullable<int> _quickWorkout;
		
		private System.Nullable<int> _sportType;
		
		private System.Nullable<int> _trackIndex;
		
		private System.Nullable<int> _virtualPartner;
		
		private string _workout;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnFirstLapIndexChanged();
		
				partial void OnFirstLapIndexChanging(System.Nullable<int> value);
		
				partial void OnGarminDeviceChanged();
		
				partial void OnGarminDeviceChanging(System.Nullable<int> value);
		
				partial void OnIDChanged();
		
				partial void OnIDChanging(System.Nullable<int> value);
		
				partial void OnLastLapIndexChanged();
		
				partial void OnLastLapIndexChanging(System.Nullable<int> value);
		
				partial void OnMultiSportChanged();
		
				partial void OnMultiSportChanging(System.Nullable<int> value);
		
				partial void OnProgramTypeChanged();
		
				partial void OnProgramTypeChanging(System.Nullable<int> value);
		
				partial void OnQuickWorkoutChanged();
		
				partial void OnQuickWorkoutChanging(System.Nullable<int> value);
		
				partial void OnSportTypeChanged();
		
				partial void OnSportTypeChanging(System.Nullable<int> value);
		
				partial void OnTrackIndexChanged();
		
				partial void OnTrackIndexChanging(System.Nullable<int> value);
		
				partial void OnVirtualPartnerChanged();
		
				partial void OnVirtualPartnerChanging(System.Nullable<int> value);
		
				partial void OnWorkoutChanged();
		
				partial void OnWorkoutChanging(string value);
		#endregion
		
		public Runs()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_firstLapIndex", Name="first_lap_index", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> FirstLapIndex
		{
			get
			{
				return this._firstLapIndex;
			}
			set
			{
				if ((_firstLapIndex != value))
				{
					this.OnFirstLapIndexChanging(value);
					this.SendPropertyChanging();
					this._firstLapIndex = value;
					this.SendPropertyChanged("FirstLapIndex");
					this.OnFirstLapIndexChanged();
				}
			}
		}
		
		[Column(Storage="_garminDevice", Name="garmin__device", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> GarminDevice
		{
			get
			{
				return this._garminDevice;
			}
			set
			{
				if ((_garminDevice != value))
				{
					this.OnGarminDeviceChanging(value);
					this.SendPropertyChanging();
					this._garminDevice = value;
					this.SendPropertyChanged("GarminDevice");
					this.OnGarminDeviceChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_lastLapIndex", Name="last_lap_index", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LastLapIndex
		{
			get
			{
				return this._lastLapIndex;
			}
			set
			{
				if ((_lastLapIndex != value))
				{
					this.OnLastLapIndexChanging(value);
					this.SendPropertyChanging();
					this._lastLapIndex = value;
					this.SendPropertyChanged("LastLapIndex");
					this.OnLastLapIndexChanged();
				}
			}
		}
		
		[Column(Storage="_multiSport", Name="multi_sport", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MultiSport
		{
			get
			{
				return this._multiSport;
			}
			set
			{
				if ((_multiSport != value))
				{
					this.OnMultiSportChanging(value);
					this.SendPropertyChanging();
					this._multiSport = value;
					this.SendPropertyChanged("MultiSport");
					this.OnMultiSportChanged();
				}
			}
		}
		
		[Column(Storage="_programType", Name="program_type", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProgramType
		{
			get
			{
				return this._programType;
			}
			set
			{
				if ((_programType != value))
				{
					this.OnProgramTypeChanging(value);
					this.SendPropertyChanging();
					this._programType = value;
					this.SendPropertyChanged("ProgramType");
					this.OnProgramTypeChanged();
				}
			}
		}
		
		[Column(Storage="_quickWorkout", Name="quick_workout", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> QuickWorkout
		{
			get
			{
				return this._quickWorkout;
			}
			set
			{
				if ((_quickWorkout != value))
				{
					this.OnQuickWorkoutChanging(value);
					this.SendPropertyChanging();
					this._quickWorkout = value;
					this.SendPropertyChanged("QuickWorkout");
					this.OnQuickWorkoutChanged();
				}
			}
		}
		
		[Column(Storage="_sportType", Name="sport_type", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SportType
		{
			get
			{
				return this._sportType;
			}
			set
			{
				if ((_sportType != value))
				{
					this.OnSportTypeChanging(value);
					this.SendPropertyChanging();
					this._sportType = value;
					this.SendPropertyChanged("SportType");
					this.OnSportTypeChanged();
				}
			}
		}
		
		[Column(Storage="_trackIndex", Name="track_index", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TrackIndex
		{
			get
			{
				return this._trackIndex;
			}
			set
			{
				if ((_trackIndex != value))
				{
					this.OnTrackIndexChanging(value);
					this.SendPropertyChanging();
					this._trackIndex = value;
					this.SendPropertyChanged("TrackIndex");
					this.OnTrackIndexChanged();
				}
			}
		}
		
		[Column(Storage="_virtualPartner", Name="virtual_partner", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> VirtualPartner
		{
			get
			{
				return this._virtualPartner;
			}
			set
			{
				if ((_virtualPartner != value))
				{
					this.OnVirtualPartnerChanging(value);
					this.SendPropertyChanging();
					this._virtualPartner = value;
					this.SendPropertyChanged("VirtualPartner");
					this.OnVirtualPartnerChanged();
				}
			}
		}
		
		[Column(Storage="_workout", Name="workout", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Workout
		{
			get
			{
				return this._workout;
			}
			set
			{
				if (((_workout == value) == false))
				{
					this.OnWorkoutChanging(value);
					this.SendPropertyChanging();
					this._workout = value;
					this.SendPropertyChanged("Workout");
					this.OnWorkoutChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.steps")]
	public partial class Steps
	{
		
		private System.Nullable<int> _durationType;
		
		private System.Nullable<int> _durationValue;
		
		private System.Nullable<int> _garminUnit;
		
		private System.Nullable<int> _id;
		
		private System.Nullable<int> _intensity;
		
		private string _name;
		
		private System.Nullable<float> _targetCustomZoneHigh;
		
		private System.Nullable<float> _targetCustomZoneLow;
		
		private System.Nullable<int> _targetType;
		
		private System.Nullable<int> _targetValue;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnDurationTypeChanged();
		
				partial void OnDurationTypeChanging(System.Nullable<int> value);
		
				partial void OnDurationValueChanged();
		
				partial void OnDurationValueChanging(System.Nullable<int> value);
		
				partial void OnGarminUnitChanged();
		
				partial void OnGarminUnitChanging(System.Nullable<int> value);
		
				partial void OnIDChanged();
		
				partial void OnIDChanging(System.Nullable<int> value);
		
				partial void OnIntensityChanged();
		
				partial void OnIntensityChanging(System.Nullable<int> value);
		
				partial void OnNameChanged();
		
				partial void OnNameChanging(string value);
		
				partial void OnTargetCustomZoneHighChanged();
		
				partial void OnTargetCustomZoneHighChanging(System.Nullable<float> value);
		
				partial void OnTargetCustomZoneLowChanged();
		
				partial void OnTargetCustomZoneLowChanging(System.Nullable<float> value);
		
				partial void OnTargetTypeChanged();
		
				partial void OnTargetTypeChanging(System.Nullable<int> value);
		
				partial void OnTargetValueChanged();
		
				partial void OnTargetValueChanging(System.Nullable<int> value);
		#endregion
		
		public Steps()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_durationType", Name="duration_type", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> DurationType
		{
			get
			{
				return this._durationType;
			}
			set
			{
				if ((_durationType != value))
				{
					this.OnDurationTypeChanging(value);
					this._durationType = value;
					this.OnDurationTypeChanged();
				}
			}
		}
		
		[Column(Storage="_durationValue", Name="duration_value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> DurationValue
		{
			get
			{
				return this._durationValue;
			}
			set
			{
				if ((_durationValue != value))
				{
					this.OnDurationValueChanging(value);
					this._durationValue = value;
					this.OnDurationValueChanged();
				}
			}
		}
		
		[Column(Storage="_garminUnit", Name="garmin_unit", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> GarminUnit
		{
			get
			{
				return this._garminUnit;
			}
			set
			{
				if ((_garminUnit != value))
				{
					this.OnGarminUnitChanging(value);
					this._garminUnit = value;
					this.OnGarminUnitChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this._id = value;
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_intensity", Name="intensity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Intensity
		{
			get
			{
				return this._intensity;
			}
			set
			{
				if ((_intensity != value))
				{
					this.OnIntensityChanging(value);
					this._intensity = value;
					this.OnIntensityChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) == false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_targetCustomZoneHigh", Name="target_custom_zone_high", DbType="REAL", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> TargetCustomZoneHigh
		{
			get
			{
				return this._targetCustomZoneHigh;
			}
			set
			{
				if ((_targetCustomZoneHigh != value))
				{
					this.OnTargetCustomZoneHighChanging(value);
					this._targetCustomZoneHigh = value;
					this.OnTargetCustomZoneHighChanged();
				}
			}
		}
		
		[Column(Storage="_targetCustomZoneLow", Name="target_custom_zone_low", DbType="REAL", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> TargetCustomZoneLow
		{
			get
			{
				return this._targetCustomZoneLow;
			}
			set
			{
				if ((_targetCustomZoneLow != value))
				{
					this.OnTargetCustomZoneLowChanging(value);
					this._targetCustomZoneLow = value;
					this.OnTargetCustomZoneLowChanged();
				}
			}
		}
		
		[Column(Storage="_targetType", Name="target_type", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TargetType
		{
			get
			{
				return this._targetType;
			}
			set
			{
				if ((_targetType != value))
				{
					this.OnTargetTypeChanging(value);
					this._targetType = value;
					this.OnTargetTypeChanged();
				}
			}
		}
		
		[Column(Storage="_targetValue", Name="target_value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TargetValue
		{
			get
			{
				return this._targetValue;
			}
			set
			{
				if ((_targetValue != value))
				{
					this.OnTargetValueChanging(value);
					this._targetValue = value;
					this.OnTargetValueChanged();
				}
			}
		}
	}
	
	[Table(Name="main.workout")]
	public partial class Workout
	{
		
		private System.Nullable<int> _garminUnit;
		
		private System.Nullable<int> _id;
		
		private string _name;
		
		private System.Nullable<int> _sportType;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnGarminUnitChanged();
		
				partial void OnGarminUnitChanging(System.Nullable<int> value);
		
				partial void OnIDChanged();
		
				partial void OnIDChanging(System.Nullable<int> value);
		
				partial void OnNameChanged();
		
				partial void OnNameChanging(string value);
		
				partial void OnSportTypeChanged();
		
				partial void OnSportTypeChanging(System.Nullable<int> value);
		#endregion
		
		public Workout()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_garminUnit", Name="garmin_unit", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> GarminUnit
		{
			get
			{
				return this._garminUnit;
			}
			set
			{
				if ((_garminUnit != value))
				{
					this.OnGarminUnitChanging(value);
					this._garminUnit = value;
					this.OnGarminUnitChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this._id = value;
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) == false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_sportType", Name="sport_type", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SportType
		{
			get
			{
				return this._sportType;
			}
			set
			{
				if ((_sportType != value))
				{
					this.OnSportTypeChanging(value);
					this._sportType = value;
					this.OnSportTypeChanged();
				}
			}
		}
	}
}
