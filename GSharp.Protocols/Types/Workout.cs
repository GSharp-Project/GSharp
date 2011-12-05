using System;
using System.Collections.Generic;

namespace GSharp.Protocols
{
	public class Workout
	{
		public string Name {get; private set;}
		public SportType SportType {get; private set;}
		public List<Steps> Steps {get; private set;}
		
		public Workout (string Name, SportType sport_type, Steps[] steps)
		{
			this.Name = Name;
			this.SportType = SportType;
			this.Steps = new List<Steps>(steps);
		}
		
//		typedef struct
//		{
//			uint32 num_valid_steps; /* Number of valid steps (1-20) */
//			struct
//			{
//				char custom_name[16]; /* Null-terminated step name */
//				float32 target_custom_zone_low; /* See below */
//				float32 target_custom_zone_high; /* See below */
//				uint16 duration_value; /* See below */
//				uint8 intensity; /* Same as D1001 */
//				uint8 duration_type; /* See below */
//				uint8 target_type; /* See below */
//				uint8 target_value; /* See below */
//				uint16 unused; /* Unused. Set to 0. */
//			} steps[20];
//			char name[16]; /* Null-terminated workout name */
//			uint8 sport_type; /* Same as D1000 */
//		} D1002_Workout_Type;
		
		public static Workout CreateFrom(D1002_Workout_Type workout_struct)
		{
			byte[] name_bytes = new byte[] { 
				workout_struct.name01,
				workout_struct.name02,
				workout_struct.name03,
				workout_struct.name04,
				workout_struct.name05,
				workout_struct.name06,
				workout_struct.name07,
				workout_struct.name08,
				workout_struct.name09,
				workout_struct.name10,
				workout_struct.name11,
				workout_struct.name12,
				workout_struct.name13,
				workout_struct.name14,
				workout_struct.name15,
				workout_struct.name16 };
			string name = BitConverter.ToString(name_bytes);
			
			Steps[] steps = new Steps[] {
				workout_struct.step01,
				workout_struct.step02,
				workout_struct.step03,
				workout_struct.step04,
				workout_struct.step05,
				workout_struct.step06,
				workout_struct.step07,
				workout_struct.step08,
				workout_struct.step09,
				workout_struct.step10,
				workout_struct.step11,
				workout_struct.step12,
				workout_struct.step13,
				workout_struct.step14,
				workout_struct.step15,
				workout_struct.step16,
				workout_struct.step17,
				workout_struct.step18,
				workout_struct.step19,
				workout_struct.step20};
				
			return new Workout(name, (SportType) workout_struct.sport_type, steps);
		}
		
		public static Workout CreateFrom(D1008_Workout_Type workout_struct)
		{
			byte[] name_bytes = new byte[] { 
				workout_struct.name01,
				workout_struct.name02,
				workout_struct.name03,
				workout_struct.name04,
				workout_struct.name05,
				workout_struct.name06,
				workout_struct.name07,
				workout_struct.name08,
				workout_struct.name09,
				workout_struct.name10,
				workout_struct.name11,
				workout_struct.name12,
				workout_struct.name13,
				workout_struct.name14,
				workout_struct.name15,
				workout_struct.name16 };
			string name = BitConverter.ToString(name_bytes);
			
			Steps[] steps = new Steps[] {
				workout_struct.step01,
				workout_struct.step02,
				workout_struct.step03,
				workout_struct.step04,
				workout_struct.step05,
				workout_struct.step06,
				workout_struct.step07,
				workout_struct.step08,
				workout_struct.step09,
				workout_struct.step10,
				workout_struct.step11,
				workout_struct.step12,
				workout_struct.step13,
				workout_struct.step14,
				workout_struct.step15,
				workout_struct.step16,
				workout_struct.step17,
				workout_struct.step18,
				workout_struct.step19,
				workout_struct.step20};
				
			return new Workout(name, (SportType) workout_struct.sport_type, steps);
		}
	}
}

