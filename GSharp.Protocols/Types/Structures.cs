using System;
using System.Runtime.InteropServices;

namespace GSharp.Protocols
{
	
	[StructLayout(LayoutKind.Explicit, Pack=1)]
	public struct ProtocolDataType
	{
		[FieldOffset(0)]	public	Tags	Tag;
		[FieldOffset(1)]	public	UInt16	data;
		
		public static ProtocolDataType GetPacket(byte[] buffer)
		{
			return Protocol.ByteArrayToStructure<ProtocolDataType>(buffer);
		}
		
		public garmin_datatype GetDataType() 
		{
			return (garmin_datatype) this.data;
		}
		
		public application_protocol GetApplicationProtocol()
		{
			return (application_protocol) this.data;
		}
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct Packet
	{
		[FieldOffset(0)]	public	byte	type;
		[FieldOffset(1)]			byte	reserved1;
		[FieldOffset(2)]			byte	reserved2;
		[FieldOffset(3)]			byte	reserved3;
		[FieldOffset(4)]	public	ushort	id;
		[FieldOffset(6)]			byte	reserved4;
		[FieldOffset(7)]			byte	reserved5;
		[FieldOffset(8)]	public	uint	size;
		
		public static Packet CreatePacket (PacketType PacketType, ushort PacketID, uint DataSize)
		{
			Packet p;
			p.type = (byte) PacketType;
			p.id = PacketID;
			p.size = DataSize;
			p.reserved1 = p.reserved2 = p.reserved3 = p.reserved4 = p.reserved5 = 0;
			
			return p;
		}
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct Steps
	{
		[FieldOffset(0)]	public	byte	custom_name01;
		[FieldOffset(1)]	public	byte	custom_name02;
		[FieldOffset(2)]	public	byte	custom_name03;
		[FieldOffset(3)]	public	byte	custom_name04;
		[FieldOffset(4)]	public	byte	custom_name05;
		[FieldOffset(5)]	public	byte	custom_name06;
		[FieldOffset(6)]	public	byte	custom_name07;
		[FieldOffset(7)]	public	byte	custom_name08;
		[FieldOffset(8)]	public	byte	custom_name09;
		[FieldOffset(9)]	public	byte	custom_name10;
		[FieldOffset(10)]	public	byte	custom_name11;
		[FieldOffset(11)]	public	byte	custom_name12;
		[FieldOffset(12)]	public	byte	custom_name13;
		[FieldOffset(13)]	public	byte	custom_name14;
		[FieldOffset(14)]	public	byte	custom_name15;
		[FieldOffset(15)]	public	byte	custom_name16;
		[FieldOffset(16)]	public	float	target_custom_zone_low;
		[FieldOffset(20)]	public	float	target_custom_zone_high;
		[FieldOffset(22)]	public	ushort	duration_value;
		[FieldOffset(24)]	public	byte	intensity;
		[FieldOffset(25)]	public	byte	duration_type;
		[FieldOffset(26)]	public	byte	target_type;
		[FieldOffset(27)]	public	byte	target_value;
		[FieldOffset(28)]	public	ushort	unused;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1,Size=8)]
	public struct Position
	{
		[FieldOffset(0)]	public	int		lat;
		[FieldOffset(4)]	public	int		lon;		
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct D1008_Workout_Type
	{
		[FieldOffset(0)]	public	uint	num_valid_steps;
		[FieldOffset(4)]	public	Steps	step01;
		[FieldOffset(34)]	public	Steps	step02;
		[FieldOffset(64)]	public	Steps	step03;
		[FieldOffset(94)]	public	Steps	step04;
		[FieldOffset(124)]	public	Steps	step05;
		[FieldOffset(154)]	public	Steps	step06;
		[FieldOffset(184)]	public	Steps	step07;
		[FieldOffset(214)]	public	Steps	step08;
		[FieldOffset(244)]	public	Steps	step09;
		[FieldOffset(274)]	public	Steps	step10;
		[FieldOffset(304)]	public	Steps	step11;
		[FieldOffset(334)]	public	Steps	step12;
		[FieldOffset(364)]	public	Steps	step13;
		[FieldOffset(394)]	public	Steps	step14;
		[FieldOffset(424)]	public	Steps	step15;
		[FieldOffset(454)]	public	Steps	step16;
		[FieldOffset(484)]	public	Steps	step17;
		[FieldOffset(514)]	public	Steps	step18;
		[FieldOffset(544)]	public	Steps	step19;
		[FieldOffset(574)]	public	Steps	step20;
		[FieldOffset(575)]	public	byte	name01;
		[FieldOffset(576)]	public	byte	name02;
		[FieldOffset(577)]	public	byte	name03;
		[FieldOffset(578)]	public	byte	name04;
		[FieldOffset(579)]	public	byte	name05;
		[FieldOffset(580)]	public	byte	name06;
		[FieldOffset(581)]	public	byte	name07;
		[FieldOffset(582)]	public	byte	name08;
		[FieldOffset(583)]	public	byte	name09;
		[FieldOffset(584)]	public	byte	name10;
		[FieldOffset(585)]	public	byte	name11;
		[FieldOffset(586)]	public	byte	name12;
		[FieldOffset(587)]	public	byte	name13;
		[FieldOffset(588)]	public	byte	name14;
		[FieldOffset(589)]	public	byte	name15;
		[FieldOffset(590)]	public	byte	name16;
		[FieldOffset(591)]	public	byte	sport_type;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct QuickWorkout
	{
		[FieldOffset(0)]	public	uint	time;
		[FieldOffset(4)]	public	uint	distance;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct D1009_Run_Type
	{
		[FieldOffset(0)]	public	ushort				track_index;
		[FieldOffset(2)]	public	ushort				first_lap_index;
		[FieldOffset(4)]	public	ushort				last_lap_index;
		[FieldOffset(6)]	public	byte				sport_type;
		[FieldOffset(7)]	public	byte				program_type;
		[FieldOffset(8)]	public	MultiSport			multisport;
		[FieldOffset(9)]			byte				unused1;
		[FieldOffset(10)]			ushort				unused2;
		[FieldOffset(12)]	public	QuickWorkout		quick_workout;
		[FieldOffset(20)]	public	D1008_Workout_Type	workout;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct D1015_Lap_Type
	{		
		[FieldOffset(0)]	public	ushort	index;
		[FieldOffset(2)]			ushort	unused0;
		[FieldOffset(4)]	public	uint	start_time;
		[FieldOffset(8)]	public	uint	total_time;
		[FieldOffset(12)]	public	float	total_dist;
		[FieldOffset(16)]	public	float	max_speed;
		[FieldOffset(20)]	public	Position	begin;
		[FieldOffset(28)]	public	Position	end;
		[FieldOffset(36)]	public	ushort	calories;
		[FieldOffset(38)]	public	byte	avg_heart_rate;
		[FieldOffset(39)]	public	byte	max_heart_rate;
		[FieldOffset(40)]	public	byte	intensity;
		[FieldOffset(41)]	public	byte	avg_cadence;
		[FieldOffset(42)]	public	byte	trigger_method;
		[FieldOffset(43)]			byte	unused1;
		[FieldOffset(44)]			byte	unused2;
		[FieldOffset(45)]			byte	unused3;
		[FieldOffset(46)]			byte	unused4;
		[FieldOffset(47)]			byte	unused5;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1,Size=23)]
	public struct D304_Trk_Point_Type
	{
		[FieldOffset(0)]	public	Position	position;
		[FieldOffset(8)]	public	uint		time;
		[FieldOffset(12)]	public	float		altitude;
		[FieldOffset(16)]	public	float		distance;
		[FieldOffset(20)]	public	byte		heart_rate;
		[FieldOffset(21)]	public	byte		cadence;
		[FieldOffset(22)]	public	byte		sensor;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1,Size=2)]
	public struct D311_Trk_Hdr_Type
	{
		[FieldOffset(0)]	public	ushort		index;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1,Size=32)]
	public struct D906_Lap_Type
	{		
		[FieldOffset(0)]	public	uint	start_time;
		[FieldOffset(4)]	public	uint	total_time;
		[FieldOffset(8)]	public	byte	total_distance0;
		[FieldOffset(9)]	public	byte	total_distance1;
		[FieldOffset(10)]	public	byte	total_distance2;
		[FieldOffset(11)]	public	byte	total_distance3;
		[FieldOffset(12)]	public	Position	begin;
		[FieldOffset(20)]	public	Position	end;
		[FieldOffset(28)]	public	ushort	calories;
		[FieldOffset(30)]	public	byte	track_index;
		[FieldOffset(31)]	public	byte	unused;
		
		public float TotalDistance 
		{ 
			get 
			{ 
				byte[] total_distance = new byte[]
				{
					this.total_distance3,
					this.total_distance2,
					this.total_distance1,
					this.total_distance0
				};
				return BitConverter.ToSingle(total_distance, 0); 
			} 
		}
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct D1000_Run_Type
	{
		[FieldOffset(0)]	public	ushort	track_index;
		[FieldOffset(2)]	public	ushort	first_lap_index;
		[FieldOffset(4)]	public	ushort	last_lap_index;
		[FieldOffset(6)]	public  uint unused0;
		[FieldOffset(10)]	public ushort unused2;
		[FieldOffset(12)]	public	byte	sport_type;
		[FieldOffset(13)]	public	byte	program_type;
		[FieldOffset(14)]	public	ushort	unused1;
		[FieldOffset(16)]	public	VirtualPartner	virtual_partner;
		[FieldOffset(24)]	public	D1002_Workout_Type	workout;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1,Size=8)]
	public struct VirtualPartner
	{
		[FieldOffset(0)]	public	uint	time;
		[FieldOffset(4)]	public	float	distance;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1,Size=41)]
	public struct D1001_Lap_Type
	{
		[FieldOffset(0)]	public	uint	index;
		[FieldOffset(4)]	public	uint	start_time;
		[FieldOffset(8)]	public	uint	total_time;
		[FieldOffset(12)]	public	byte[]	total_dist;
		[FieldOffset(16)]	public	byte[]	max_speed;
		[FieldOffset(20)]	public	byte[]	begin;
		[FieldOffset(28)]	public	byte[]	end;
		[FieldOffset(36)]	public	ushort	calories;
		[FieldOffset(38)]	public	byte	avg_heart_rate;
		[FieldOffset(39)]	public	byte	max_heart_rage;
		[FieldOffset(40)]	public	byte	intensity;
		
		public Position Begin { get { return Protocol.ByteArrayToStructure<Position>(this.begin); } }
		
		public Position End { get { return Protocol.ByteArrayToStructure<Position>(this.end); } }
		
		public float TotalDistance { get { return BitConverter.ToSingle(this.total_dist, 0); } }
		
		public float MaxSpeed { get { return BitConverter.ToSingle(this.max_speed, 0); } }
		
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct D1002_Workout_Type
	{
		[FieldOffset(0)]	public	uint	num_valid_steps;
		[FieldOffset(4)]	public	Steps	step01;
		[FieldOffset(34)]	public	Steps	step02;
		[FieldOffset(64)]	public	Steps	step03;
		[FieldOffset(94)]	public	Steps	step04;
		[FieldOffset(124)]	public	Steps	step05;
		[FieldOffset(154)]	public	Steps	step06;
		[FieldOffset(184)]	public	Steps	step07;
		[FieldOffset(214)]	public	Steps	step08;
		[FieldOffset(244)]	public	Steps	step09;
		[FieldOffset(274)]	public	Steps	step10;
		[FieldOffset(304)]	public	Steps	step11;
		[FieldOffset(334)]	public	Steps	step12;
		[FieldOffset(364)]	public	Steps	step13;
		[FieldOffset(394)]	public	Steps	step14;
		[FieldOffset(424)]	public	Steps	step15;
		[FieldOffset(454)]	public	Steps	step16;
		[FieldOffset(484)]	public	Steps	step17;
		[FieldOffset(514)]	public	Steps	step18;
		[FieldOffset(544)]	public	Steps	step19;
		[FieldOffset(574)]	public	Steps	step20;
		[FieldOffset(575)]	public	byte	name01;
		[FieldOffset(576)]	public	byte	name02;
		[FieldOffset(577)]	public	byte	name03;
		[FieldOffset(578)]	public	byte	name04;
		[FieldOffset(579)]	public	byte	name05;
		[FieldOffset(580)]	public	byte	name06;
		[FieldOffset(581)]	public	byte	name07;
		[FieldOffset(582)]	public	byte	name08;
		[FieldOffset(583)]	public	byte	name09;
		[FieldOffset(584)]	public	byte	name10;
		[FieldOffset(585)]	public	byte	name11;
		[FieldOffset(586)]	public	byte	name12;
		[FieldOffset(587)]	public	byte	name13;
		[FieldOffset(588)]	public	byte	name14;
		[FieldOffset(589)]	public	byte	name15;
		[FieldOffset(590)]	public	byte	name16;
		[FieldOffset(591)]	public	byte	sport_type;
	}
	
	[StructLayout(LayoutKind.Explicit,Pack=1)]
	public struct Product
	{
		[FieldOffset(0)] public byte 	product_id1;		
		[FieldOffset(1)] public byte 	product_id2;
		[FieldOffset(2)] public byte	software_version1;
		[FieldOffset(3)] public byte	software_version2;
		
		public UInt16 ProductID
		{
			get
			{
				byte[] temp = new byte[2];
				temp[0] = this.product_id1;
				temp[1] = this.product_id2;
				return BitConverter.ToUInt16(temp,0);
			}
		}
		
		public short SoftwareVersion
		{
			get
			{
				byte[] temp = new byte[2];
				temp[0] = this.software_version1;
				temp[1] = this.software_version2;
				return BitConverter.ToInt16(temp,0);
			}
		}
	}
}

