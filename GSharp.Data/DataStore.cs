using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Mono.Data.Sqlite;
using GSharp.Protocols;

namespace GSharp.Data
{
	public class DataStore
	{
		Main database;
		
		public DataStore ()
		{
#if WHACKDB
			File.Delete("GSharp.db3");
#endif
			SqliteConnection conn;
			
			if ( !File.Exists("GSharp.db3"))
			{
				SqliteConnection.CreateFile("GSharp.db3");
	        	using ( conn = new SqliteConnection ("DbLinqProvider=Sqlite;Data Source=GSharp.db3") )
				{
					var s = Assembly.GetExecutingAssembly().GetManifestResourceStream("GSharp.Data.GSharp.sql");
					var sr = new StreamReader(s);
					using ( var cmd = conn.CreateCommand() )
					{
						cmd.CommandText = sr.ReadToEnd();
						cmd.CommandType = CommandType.Text;
						conn.Open();
						cmd.ExecuteNonQuery();
						conn.Close();
					}
				}
			}
			conn = new SqliteConnection ("DbLinqProvider=Sqlite;Data Source=GSharp.db3");
			database = new Main (conn);
		}
		
		public bool ContainsGarmin(int garmin_id)
		{
			if ( database.GarminDevices.Count() != 0 )
				return database.GarminDevices.Where( g => g.ID == garmin_id).Count() > 0;
			return false;
		}
		
		public string GetGarminName(int garmin_id)
		{
			if ( database.GarminDevices.Count() != 0 )
				return database.GarminDevices.Where( g => g.ID == garmin_id ).First().Name;
			return String.Empty;
		}
		
		public void InsertGarmin(int garmin_id, string name)
		{
			var garmin = new GarminDevices()
			{
				ID = garmin_id,
				Name = name
			};
			
			database.GarminDevices.InsertOnSubmit(garmin);
			database.SubmitChanges();
		}
		
		public IEnumerable<Runs> GetRuns(int garmin_id)
		{
			var runs = from r in database.Runs where r.ID == garmin_id select r;
			foreach ( var run in runs )
				yield return run;
		}
		
		public void AddRun(GarminUnit garmin, Run run)
		{
			var runs = new Runs() 
			{
				FirstLapIndex = run.FirstLapIndex,
				LastLapIndex = run.LastLapIndex,
				SportType = (int) run.SportType,
				ProgramType = run.ProgramType,
				MultiSport = (int) run.MultiSport,
//				QuickWorkout = (int) run.QuickWorkout,
//				Workout = (int) run.Workout,
//				VirtualPartner = (int) run.VirtualPartner
			};
			
			database.Runs.InsertOnSubmit(runs);
			database.SubmitChanges();
		}
		
		public bool ContainsRun(GarminUnit garmin, Run run)
		{
			if ( database.Runs.Count() == 0 )
				return false;
			var runs = from r in database.Runs
						where r.GarminDevice == (int) garmin.ID
						where r.FirstLapIndex == (int) run.FirstLapIndex
						where r.LastLapIndex == (int) run.LastLapIndex
						select r;
			return (runs.Count() > 0);
		}
		
		public IEnumerable<Laps> GetLaps(int garmin_id, int first_lap_index, int last_lap_index)
		{
			var laps = from l in database.Laps
				where l.GarminUnit == garmin_id
					&& l.Index >= first_lap_index
					&& l.Index <= last_lap_index
					select l;
			foreach ( var lap in laps )
				yield return lap;
		}
		
		public bool ContainsLap(GarminUnit garmin, Lap lap)
		{
			if ( database.Laps.Count() == 0 )
				return false;
			var laps = from l in database.Laps
				where l.GarminUnit == (int) garmin.ID
				where l.Index == (int) lap.Index
				select l;
			return (laps.Count() > 0);
		}
		
		public void AddLap(GarminUnit garmin, Lap lap)
		{
			
			var l = new Laps()
			{
				AvgCadence = lap.AvgCadence,
				AvgHeartRage = lap.AvgHeartRate,
				Calories = lap.CaloriesBurned,
				EndLat = lap.End.lat,
				EndLon = lap.End.lon,
				GarminUnit = (int) garmin.ID,
				Index = lap.Index,
				Intensity = lap.Intensity,
				MaxHeartRage = lap.MaxHeartRate,
				MaxSpeed = lap.MaxSpeed,
				StartLat = lap.Begin.lat,
				StartLon = lap.Begin.lon,
				StartTime = lap.StartTime.,
				TotalDist = lap.TotalDistance,
				TotalTime = lap.TotalTime,
				TriggerMethod = lap.TriggerMethod
			};
			database.Laps.InsertOnSubmit(l);
			database.SubmitChanges();
		}
	}
}

