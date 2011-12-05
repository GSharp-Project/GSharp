using System;

namespace GSharp.Protocols
{
	public class Run
	{
		public 	ushort			TrackIndex;
		public	ushort			FirstLapIndex;		
		public	ushort			LastLapIndex;
		public	SportType		SportType;
		public	byte			ProgramType;
		public	MultiSport		MultiSport;
		public	QuickWorkout	QuickWorkout;
		public	Workout			Workout;
		public	VirtualPartner	VirtualPartner;
		
		public Run ()
		{
		}
		
//		typedef struct
//		{
//			uint32 track_index; /* Index of associated track */
//			uint32 first_lap_index; /* Index of first associated lap */
//			uint32 last_lap_index; /* Index of last associated lap */
//			uint8 sport_type; /* See below */
//			uint8 program_type; /* See below */
//			uint16 unused; /* Unused. Set to 0. */
//			struct
//			{
//				uint32 time; /* Time result of virtual partner */
//				float32 distance; /* Distance result of virtual partner */
//			} virtual_partner;
//			D1002_Workout_Type workout; /* Workout */
//		} D1000_Run_Type
			
		public static Run CreateFrom(D1000_Run_Type run_struct)
		{
			var run = new Run();
			run.TrackIndex = run_struct.track_index;
			run.FirstLapIndex = run_struct.first_lap_index;
			run.LastLapIndex = run_struct.last_lap_index;
			run.SportType = (SportType) run_struct.sport_type;
			run.ProgramType = run_struct.program_type;
			//run.multisport = (MultiSport) run_struct.multisport;
			//run.QuickWorkout = run_struct.quick_workout;
			run.VirtualPartner = run_struct.virtual_partner;
			run.Workout = Workout.CreateFrom(run_struct.workout);
			return run;
		}
		
//		typedef struct
//		{
//			uint16 track_index; /* Index of associated track */
//			uint16 first_lap_index; /* Index of first associated lap */
//			uint16 last_lap_index; /* Index of last associated lap */
//			uint8 sport_type; /* Same as D1000 */
//			uint8 program_type; /* See below */
//			uint8 multisport; /* See below */
//			uint8 unused1; /* Unused. Set to 0. */
//			uint16 unused2; /* Unused. Set to 0. */
//			struct
//			{
//				uint32 time; /* Time result of quick workout */
//				float32 distance; /* Distance result of quick workout */
//			} quick_workout;
//			D1008_Workout_Type workout; /* Workout */
//		} D1009_Run_Type;
		
		public static Run CreateFrom(D1009_Run_Type run_struct)
		{
			var run = new Run();
			run.TrackIndex = run_struct.track_index;
			run.FirstLapIndex = run_struct.first_lap_index;
			run.LastLapIndex = run_struct.last_lap_index;
			run.SportType = (SportType) run_struct.sport_type;
			run.ProgramType = run_struct.program_type;
			run.MultiSport = (MultiSport) run_struct.multisport;
			run.QuickWorkout = run_struct.quick_workout;
			run.Workout = Workout.CreateFrom(run_struct.workout);
			return run;
		}
	}
}

