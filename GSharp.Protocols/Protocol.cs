using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GSharp.Protocols
{
	
	public static class Protocol
	{
	
		public enum PacketID
		{
			DataAvailable	= 2,
			StartSession	= 5,
			SessionStarted	= 6,
			
			// L000 Basic Link Protocol
			ProtocolArray	= 253,
			ProductRequest	= 254,
			ProductData		= 255,
			ExtProductData	= 248,
			
			// L001 Link Protocol 1
			Command_Data	= 10,
			Xfer_Cmplt		= 12,
			Date_Time_Data	= 14,
			Position_Data	= 17,
			Prx_Wpt_Data 	= 19,
			Records 		= 27,
			Rte_Hdr 		= 29,
			Rte_Wpt_Data 	= 30,
			Almanac_Data 	= 31,
			Trk_Data 		= 34,
			Wpt_Data 		= 35,
			Pvt_Data 		= 51,
			Rte_Link_Data 	= 98,
			Trk_Hdr	 		= 99,
			FlightBook_Record = 134,
			Lap 			= 149,
			Wpt_Cat 		= 152,
			Run 			= 990,
			Workout 		= 991,
			Workout_Occurrence = 992,
			Fitness_User_Profile = 993,
			Workout_Limits 	= 994,
			Course 			= 1061,
			Course_Lap 		= 1062,
			Course_Point 	= 1063,
			Course_Trk_Hdr 	= 1064,
			Course_Trk_Data = 1065,
			Course_Limits	= 1066,
			
			// L002 Link Protocol 2
			L002_Almanac_Data = 4,
			L002_Command_Data = 11,
			L002_Xfer_Cmplt = 12,
			L002_Date_Time_Data = 20,
			L002_Position_Data = 24,
			L002_Prx_Wpt_Data = 27,
			L002_Records = 35,
			L002_Rte_Hdr = 37,
			L002_Rte_Wpt_Data = 39,
			L002_Wpt_Data = 43
		}
		
		public static void AssignProtocols(GarminUnit garmin, application_protocol protocol, List<garmin_datatype> datatypes)
		{
			switch (protocol)
			{
			case application_protocol.appl_A010:
			case application_protocol.appl_A011:
				garmin.SetCapability("protocol.command",(ushort) protocol);				
				break;
				
			case application_protocol.appl_A100:
				garmin.SetCapability("protocol.waypoint.waypoint",(ushort) protocol);
				garmin.SetCapability("datatype.waypoint.waypoint",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A101:
				garmin.SetCapability("protocol.waypoint.category",(ushort) protocol);
				garmin.SetCapability("datatype.waypoint.category",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A200:
				garmin.SetCapability("protocol.route",(ushort) protocol);
				garmin.SetCapability("datatype.route.header",(ushort) datatypes[0]);	
				garmin.SetCapability("datatype.route.waypoint",(ushort) datatypes[1]);	
				break;
				
			case application_protocol.appl_A201:
				garmin.SetCapability("protocol.route",(ushort) protocol);
				garmin.SetCapability("datatype.route.header",(ushort) datatypes[0]);	
				garmin.SetCapability("datatype.route.waypoint",(ushort) datatypes[1]);	
				garmin.SetCapability("datatype.route.link",(ushort) datatypes[1]);	
				break;
				
			case application_protocol.appl_A300:
				garmin.SetCapability("protocol.track",(ushort) protocol);
				garmin.SetCapability("datatype.track.data",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A301:
				garmin.SetCapability("protocol.track",(ushort) protocol);
				garmin.SetCapability("datatype.track.header",(ushort) datatypes[0]);	
				garmin.SetCapability("datatype.track.data",(ushort) datatypes[1]);	
				break;
				
			case application_protocol.appl_A400:
				garmin.SetCapability("protocol.waypoint.proximity",(ushort) protocol);
				garmin.SetCapability("datatype.waypoint.proximity",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A500:
				garmin.SetCapability("protocol.almanac",(ushort) protocol);
				garmin.SetCapability("datatype.almanac",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A600:
				garmin.SetCapability("protocol.date_time",(ushort) protocol);
				garmin.SetCapability("datatype.date_time",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A601:
				// UNDOCUMENTED	
				break;
				
			case application_protocol.appl_A650:
				garmin.SetCapability("protocol.flightbook",(ushort) protocol);
				garmin.SetCapability("datatype.flightbook",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A700:
				garmin.SetCapability("protocol.position",(ushort) protocol);
				garmin.SetCapability("datatype.position",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A800:
				garmin.SetCapability("protocol.pvt",(ushort) protocol);
				garmin.SetCapability("datatype.pvt",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A801:
				// UNDOCUMENTED	
				break;
				
			case application_protocol.appl_A902:
				// UNDOCUMENTED	
				break;
				
			case application_protocol.appl_A903:
				// UNDOCUMENTED	
				break;
				
			case application_protocol.appl_A906:
				garmin.SetCapability("protocol.lap",(ushort) protocol);
				garmin.SetCapability("datatype.lap",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1000:
				garmin.SetCapability("protocol.run",(ushort) protocol);
				garmin.SetCapability("datatype.run",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1002:
				garmin.SetCapability("protocol.workout.workout",(ushort) protocol);
				garmin.SetCapability("datatype.workout.workout",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1003:
				garmin.SetCapability("protocol.workout.occurrence",(ushort) protocol);
				garmin.SetCapability("datatype.workout.occurrence",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1004:
				garmin.SetCapability("protocol.fitness",(ushort) protocol);
				garmin.SetCapability("datatype.fitness",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1005:
				garmin.SetCapability("protocol.workout.limits",(ushort) protocol);
				garmin.SetCapability("datatype.workout.limits",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1006:
				garmin.SetCapability("protocol.course.course",(ushort) protocol);
				garmin.SetCapability("datatype.course.course",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1007:
				garmin.SetCapability("protocol.course.lap",(ushort) protocol);
				garmin.SetCapability("datatype.course.lap",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1008:
				garmin.SetCapability("protocol.course.point",(ushort) protocol);
				garmin.SetCapability("datatype.course.point",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1009:
				garmin.SetCapability("protocol.course.limits",(ushort) protocol);
				garmin.SetCapability("datatype.course.limits",(ushort) datatypes[0]);		
				break;
				
			case application_protocol.appl_A1012:
				garmin.SetCapability("protocol.course.track",(ushort) protocol);
				garmin.SetCapability("datatype.course.track.header",(ushort) datatypes[0]);	
				garmin.SetCapability("datatype.course.track.data",(ushort) datatypes[1]);	
				break;
				
			default:
				break;
			}
		}
		
		public static T ByteArrayToStructure<T>(byte[] bytes)
		{
			T t;
			var size = Marshal.SizeOf(typeof(T));
			IntPtr ptr = Marshal.AllocHGlobal(size);
			Marshal.Copy(bytes,0,ptr,size);
			t = (T) Marshal.PtrToStructure(ptr,typeof(T));
			Marshal.FreeHGlobal(ptr);
			return t;
		}
		
		public static byte[] StructureToByteArray<T>(T Structure)
		{
			byte[] bytes = new byte[Marshal.SizeOf(typeof(T))];
			GCHandle pinStructure = GCHandle.Alloc(Structure, GCHandleType.Pinned);
			try
			{
				Marshal.Copy(pinStructure.AddrOfPinnedObject(),bytes,0,bytes.Length);
				return bytes;
			}
			finally
			{
				pinStructure.Free();
			}
		}
		
		public static uint StartSession (GarminUnit garmin)
		{
			Packet p = Packet.CreatePacket(PacketType.USB, (ushort) Protocol.PacketID.StartSession, 0);
			garmin.Write(p);
			byte[] buffer;
			int buffer_size = garmin.Read(out p, out buffer);
			if ( buffer_size == 16 )
			{
				return BitConverter.ToUInt32(buffer,0);
			}
			return 0;
		}
		
		public static List<T> TransferItems<T>(GarminUnit garmin, ushort command, PacketID pid)
		{
			byte[] buffer = BitConverter.GetBytes(command);
			Packet p = MakeCommandPacket(garmin, (uint) buffer.Length);
			garmin.Write(p,buffer);
			return ReadRecords<T>(garmin, pid);
			
		}
		
		public static Packet MakeCommandPacket(GarminUnit garmin, uint data_length)
		{
			return Packet.CreatePacket(PacketType.Application, (ushort) PacketID.Command_Data, data_length);
		}
		 
		public static List<T> ReadRecords<T>(GarminUnit garmin, PacketID pid)
		{
			List<T> items = new List<T>();
			Packet p = Packet.CreatePacket(GSharp.Protocols.PacketType.Application, (ushort) pid, 0);
			byte[] buffer = new byte[Marshal.SizeOf(typeof(Packet)) + 1024];
			ushort expected_items = 0, received_items = 0;
			bool done = false;
			if ( garmin.Read(out p, out buffer) > 0)
			{
				if (p.id == (ushort) PacketID.Records)
				{
					expected_items = BitConverter.ToUInt16(buffer, 0);
					while ( !done && garmin.Read(out p, out buffer)>0)
					{
						if ( p.id == (ushort) pid )
						{
							items.Add(ByteArrayToStructure<T>(buffer));
							received_items++;
						}
						else if ( p.id == (ushort) PacketID.Xfer_Cmplt )
						{
							if ( received_items != expected_items )
								throw new Exception("items received is different from expected items");
							done = true;
						}
						else
						{
							done = true;
						}
					}
				}
			}
			return items;
		}
		
//		public static List<T> ReadRuns<T>(GarminUnit garmin)
//		{
//			return TransferItems<T>(garmin, (ushort) Command.ID.Transfer_Runs, PacketID.Run);
//		}
		
		public static Type GetProtocolType(GarminUnit garmin, string protocol_name)
		{
			ushort protocol = garmin.Configuration[protocol_name];
			if ( protocol_name.StartsWith("protocol") )
			{
				///TODO: figure out if this needs to be implemented
			}
			else if ( protocol_name.StartsWith("datatype") )
			{
				switch (protocol)
				{
				case 304: return typeof(D304_Trk_Point_Type); break;
				case 311: return typeof(D311_Trk_Hdr_Type); break;
				case 906: return typeof(D906_Lap_Type); break;
				case 1000: return typeof(D1000_Run_Type); break;
				case 1001: return typeof(D1001_Lap_Type); break;
				case 1002: return typeof(D1002_Workout_Type); break;
				case 1008: return typeof(D1008_Workout_Type); break;
				case 1009: return typeof(D1009_Run_Type); break;
				case 1015: return typeof(D1015_Lap_Type); break;
				}
			}
			return null;
		}
	}
}

