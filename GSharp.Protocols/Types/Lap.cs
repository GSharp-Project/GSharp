using System;

namespace GSharp.Protocols
{
	public class Lap
	{	
		private static DateTime epoch = new DateTime(1989, 12, 31, 0, 0, 0, DateTimeKind.Utc);
		
		public	ushort		Index;
		public	DateTime	StartTime;
		public	TimeSpan	TotalTime;
		public	float		TotalDistance;
		public	float		MaxSpeed;
		public	Position	Begin;
		public	Position	End;
		public	int			CaloriesBurned;
		public	int			AvgHeartRate;
		public	int			MaxHeartRate;
		public	int			Intensity;
		public	int			AvgCadence;
		public	int			TriggerMethod;
		
		internal Lap ()
		{
		}
		
		public static Lap CreateFrom(D1015_Lap_Type lap_type)
		{
			Lap lap = new Lap();
			
			lap.Index = lap_type.index;
			lap.TotalDistance = lap_type.total_dist;
			lap.MaxSpeed = lap_type.max_speed;
			lap.Begin = lap_type.begin;
			lap.End = lap_type.end;
			lap.CaloriesBurned = (int) lap_type.calories;
			lap.AvgHeartRate = (int) lap_type.avg_heart_rate;
			lap.MaxHeartRate = (int) lap_type.max_heart_rate;
			lap.Intensity = (int) lap_type.intensity;
			lap.AvgCadence = (int) lap_type.avg_cadence;
			lap.TriggerMethod = (int) lap_type.trigger_method;
			
			
			lap.StartTime = epoch.AddSeconds(lap_type.start_time).ToLocalTime();
			
			uint days = lap_type.total_time % 86400;
			uint hours = (lap_type.total_time - days) % 3600;
			uint minutes = (lap_type.total_time - days - hours) % 60;
			uint seconds = lap_type.total_time - days - hours - minutes;
			lap.TotalTime = new TimeSpan((int) days, (int) hours, (int) minutes, (int) seconds);
			
			return lap;
		}
	}
}

