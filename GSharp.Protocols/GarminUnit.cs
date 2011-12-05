using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using LibUsbDotNet.Descriptors;

namespace GSharp.Protocols
{
	
	public class GarminUnit
	{
		public uint ID {get; private set;}		
		public ushort ProductID;
		public short SoftwareVersion;
		public string ProductDescription;
		public string AdditionalData;
		public String ExtendedData {get; set;}
		public UsbEndpointReader Reader;
		public UsbEndpointWriter Writer;
		
		public bool IsOpen = false;
		
		public Dictionary<string,ushort> Configuration;
		
		public GarminUnit (UsbDevice Device)
		{
			Configuration = new Dictionary<string, ushort>();
			
			IUsbDevice wholedevice = Device as IUsbDevice;
			if ( !ReferenceEquals(wholedevice, null))
			{
				wholedevice.SetConfiguration(1);
				wholedevice.ClaimInterface(0);
			}
			Reader = Device.OpenEndpointReader(ReadEndpointID.Ep01);
			Writer = Device.OpenEndpointWriter(WriteEndpointID.Ep02);
		}
		
		public void Init()
		{
			this.ID = Protocol.StartSession(this);
			Command.GetCapability(this);
			this.IsOpen = true;
		}
		
		public void ListCapabilities ()
		{
			foreach(var conf in Configuration.Keys)
			{
				Console.WriteLine("{0,-40}{1}", conf, Configuration[conf]);
			}
		}
		
		public void SetCapability(string name, ushort data)
		{
			if (this.Configuration.ContainsKey(name))
				return;
			this.Configuration.Add(name, data);
		}
		
		public int Write(Packet packet, byte[] payload)
		{
			byte[] header_bytes = Protocol.StructureToByteArray<Packet>(packet);
			byte[] packet_bytes = new byte[header_bytes.Length + payload.Length];
			Array.Copy(header_bytes,packet_bytes, header_bytes.Length);
			Array.Copy(payload,0,packet_bytes,header_bytes.Length,payload.Length);
			return Write(packet_bytes);
		}
		
		public int Write(Packet packet)
		{
			byte[] buffer = Protocol.StructureToByteArray<Packet>(packet);
			return Write(buffer);
		}
		
		public int Write(byte[] buffer)
		{
			int bytes_written;
			ErrorCode error_code = ErrorCode.None;
			
			error_code = Writer.Write(buffer, 2000, out bytes_written);
			
			if ( error_code != ErrorCode.None )
				throw new Exception(UsbDevice.LastErrorString);
			return bytes_written;
		}
		
		public int Read(out Packet packet, out byte[] packet_data)
		{
			int packet_header_size = Marshal.SizeOf(typeof(Packet));
			int packet_size = packet_header_size+1024;
			byte[] buffer = new byte[packet_size];
			ErrorCode error_code;
			int bytes_read;
			
			error_code = Reader.Read(buffer,0,buffer.Length,100,out bytes_read);	
			
			if ( error_code != ErrorCode.None )
				throw new Exception(UsbDevice.LastErrorString);
			
			if ( bytes_read == 0 )
				throw new Exception(UsbDevice.LastErrorString);
			
			byte[] packet_header_bytes = new byte[packet_header_size];	
			
			Array.Copy(buffer,packet_header_bytes,packet_header_size);
			
			packet = Protocol.ByteArrayToStructure<Packet>(packet_header_bytes);
			
			packet_data = new byte[packet.size];
			
			Array.Copy(buffer,packet_header_size,packet_data,0,packet.size);
			
			return bytes_read;
		}
		
		public void SetProductType(Product product, string Description)
		{
			this.ProductID = product.ProductID;
			this.SoftwareVersion = product.SoftwareVersion;
			this.ProductDescription = Description;
		}
		
		public void SetExtendedDescription(string Description)
		{
			this.AdditionalData = Description;
		}
		
		public List<Lap> GetLaps()
		{
			List<Lap> laps = new List<Lap>();
			garmin_datatype laptype = (garmin_datatype) this.Configuration["datatype.lap"];
			
			switch (laptype)
			{
			case garmin_datatype.data_D1015:
				foreach ( var lap in Protocol.TransferItems<D1015_Lap_Type>(this, (ushort) Command.ID.Transfer_Laps, Protocol.PacketID.Lap))
				{
					laps.Add(Lap.CreateFrom(lap));
				}
				break;
			default:
				break;
			}
			return laps;
		}
		
		public List<Run> GetRuns()
		{
			List<Run> runs = new List<Run>();
			garmin_datatype runtype = (garmin_datatype) this.Configuration["datatype.run"];
			application_protocol apptype = (application_protocol) this.Configuration["protocol.run"];
			
			switch (runtype)
			{
			case garmin_datatype.data_D1000:
				throw new NotImplementedException();
				break;
				
			case garmin_datatype.data_D1009:
				foreach (var run in Protocol.TransferItems<D1009_Run_Type>(this, (ushort) Command.ID.Transfer_Runs, Protocol.PacketID.Run))
				{
					runs.Add(Run.CreateFrom(run));
				}
				break;
				
			case garmin_datatype.data_D1010:
				throw new NotImplementedException();
				break;
				
			default:
				break;
			}
			
			return runs;
		}
	}
}

