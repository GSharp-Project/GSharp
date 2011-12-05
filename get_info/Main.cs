using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GSharp.Protocols;

namespace get_info
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Garmin g = Garmin.GetInstance();
			
			foreach ( var unit in g.GarminUnits)
			{
				Console.WriteLine("Unit ID: {0} {1}", unit.ID, unit.ProductDescription);
				//unit.ListCapabilities();
				//ushort run_proto = unit.Configuration["protocol.runs"];
//				Type run_type = Protocol.GetProtocolType(unit, "datatype.run");
//				Type list_type =  typeof(List<>);
//				Type combined_type = list_type.MakeGenericType(run_type);
//				IList runs_list = (IList) Activator.CreateInstance(combined_type);
//				runs_list = Protocol.ReadRuns<run_type>(unit);
//				
				foreach ( var run in unit.GetRuns() )
				{
					Console.WriteLine("Track Index: {0,-5} First Lap Index {1,-5} Last Lap Index {2,-5}",
						run.TrackIndex, run.FirstLapIndex, run.LastLapIndex);
				}
			}
		}
	}
}
