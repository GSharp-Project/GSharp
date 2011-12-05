using System;
using System.Collections.Generic;

namespace GSharp.Protocols
{
	public static class Command
	{
		public enum ID
		{
			Abort_Transfer = 0, /* abort current transfer */
			Transfer_Alm = 1, /* transfer almanac */
			Transfer_Posn = 2, /* transfer position */
			Transfer_Prx = 3, /* transfer proximity waypoints */
			Transfer_Rte = 4, /* transfer routes */
			Transfer_Time = 5, /* transfer time */
			Transfer_Trk = 6, /* transfer track log */
			Transfer_Wpt = 7, /* transfer waypoints */
			Turn_Off_Pwr = 8, /* turn off power */
			Start_Pvt_Data = 49, /* start transmitting PVT data */
			Stop_Pvt_Data = 50, /* stop transmitting PVT data */
			FlightBook_Transfer = 92, /* transfer flight records */
			Transfer_Laps = 117, /* transfer fitness laps */
			Transfer_Wpt_Cats = 121, /* transfer waypoint categories */
			Transfer_Runs = 450, /* transfer fitness runs */
			Transfer_Workouts = 451, /* transfer workouts */
			Transfer_Workout_Occurrences = 452, /* transfer workout occurrences */
			Transfer_Fitness_User_Profile = 453, /* transfer fitness user profile */
			Transfer_Workout_Limits = 454, /* transfer workout limits */
			Transfer_Courses = 561, /* transfer fitness courses */
			Transfer_Course_Laps = 562, /* transfer fitness course laps */
			Transfer_Course_Points = 563, /* transfer fitness course points */
			Transfer_Course_Tracks = 564, /* transfer fitness course tracks */
			Transfer_Course_Limits = 565 /* transfer fitness course limits */
		}
		
		public static void GetCapability(GarminUnit garmin)
		{
			Packet p;
			bool done = false;
			
			p = Packet.CreatePacket(PacketType.Application, (ushort) Protocol.PacketID.ProductRequest,0);
			garmin.Write(Protocol.StructureToByteArray<Packet>(p));
			byte[] packet_data;
			while ( !done && garmin.Read(out p, out packet_data) > 0 )
			{
				switch (p.id)
				{
				case (ushort) Protocol.PacketID.ProductData:
					byte[] pdt_array = new byte[4];
					Array.Copy(packet_data,pdt_array,4);
					int pdt_descr_size = packet_data.Length - 4;
					byte[] pdt_descr_array = new byte[pdt_descr_size];
					Product pdt = Protocol.ByteArrayToStructure<Product>(pdt_array);
					Array.Copy(packet_data,4,pdt_descr_array,0,pdt_descr_size);
					garmin.SetProductType(pdt,System.Text.ASCIIEncoding.ASCII.GetString(pdt_descr_array));
					break;
				case (ushort) Protocol.PacketID.ExtProductData:
					var extended_data = System.Text.ASCIIEncoding.ASCII.GetString(packet_data);
					garmin.SetExtendedDescription(extended_data);
					break;
				case (ushort) Protocol.PacketID.ProtocolArray:
					int size = packet_data.Length/3;
					ProtocolDataType[] data_types = new ProtocolDataType[size];
					for ( int i=0; i<size; i++)
					{
						byte[] temp_buffer = new byte[3];
						Array.Copy(packet_data,i*3,temp_buffer,0,3);
						data_types[i] = ProtocolDataType.GetPacket(temp_buffer);
					}
					int j = 0;
					while ( j < size )
					{
						switch (data_types[j].Tag)
						{
						case Tags.Phys_Prot_Id:
							garmin.SetCapability("protocol.physical", data_types[j].data);
							j++;
							break;
						case Tags.Link_Prot_Id:
							garmin.SetCapability("protocol.link", data_types[j].data);
							j++;
							break;
						case Tags.Appl_Prot_Id:
							application_protocol app = data_types[j].GetApplicationProtocol();
							List<garmin_datatype> phys = new  List<garmin_datatype>();
							for (++j; j<size; j++)
							{
								if ( data_types[j].Tag != Tags.Data_Type_Id )
								{
									Protocol.AssignProtocols(garmin,app,phys);
									break;
								}
								phys.Add(data_types[j].GetDataType());							
							}
							break;
						case Tags.Data_Type_Id:
							// taken care of in application protocol section
							break;
						default:
							j++;
							break;
						}
					}	
					

					done = true;
					break;
				default:
					break;
				}
			}
		}
	}
}