using System;
using System.Linq;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using GSharp.Protocols;

namespace GSharp.Data
{
	public class DataStore
	{
		Main database;
		
		public DataStore ()
		{
	        var conn = new SqliteConnection (
	                "DbLinqProvider=Sqlite;" + 
	                "Data Source=GSharp.db3"
	        );
	       database = new Main (conn);
		}
		
		public string GetGarminName(int garmin_id)
		{
			if ( database.GarminDevices.Count() == 0 )
				return String.Empty;
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
		
		public void AddRuns(GarminUnit garmin, Run run)
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
	}
}

