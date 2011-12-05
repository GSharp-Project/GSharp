using System;

namespace GSharp.Protocols
{		
	public enum SportType
	{
		Running = 0,
		Biking = 1,
		Other = 2,
		UNKNOWN = 255
	}
	
	public enum Tags : byte
	{
		Phys_Prot_Id = 0x50, /* 'P' : tag for Physical protocol ID 		*/
		Link_Prot_Id = 0x4c, /* ‘L’ : tag for Link protocol ID 			*/
		Appl_Prot_Id = 0x41, /* ‘A’ : tag for Application protocol ID 	*/
		Data_Type_Id = 0x44  /* ‘D’ : tag for Data Type ID 				*/
	}
	
	public enum PacketType
	{
		USB = 0,
		Application = 20
	}
	
	public enum ProgramType : byte
	{
		VirtualPartner	= 1,
		Workout			= 2,
		QuickWorkout	= 4,
		Course			= 8,
		Interval		= 16,
		MultiSport		= 32
	}
	
	public enum MultiSport : byte
	{
		No					= 0,
		Yes					= 1,
		YesAndLastInGroup	= 2
	}
	
	public enum garmin_datatype
	{
		data_Dnil  =    0,
		data_Dlist =    1,      /* List of data */
		data_D100  =  100,      /* waypoint */
		data_D101  =  101,      /* waypoint */
		data_D102  =  102,      /* waypoint */
		data_D103  =  103,      /* waypoint */
		data_D104  =  104,      /* waypoint */
		data_D105  =  105,      /* waypoint */
		data_D106  =  106,      /* waypoint */
		data_D107  =  107,      /* waypoint */
		data_D108  =  108,      /* waypoint */
		data_D109  =  109,      /* waypoint */
		data_D110  =  110,      /* waypoint */
		data_D120  =  120,      /* waypoint category */
		data_D150  =  150,      /* waypoint */
		data_D151  =  151,      /* waypoint */
		data_D152  =  152,      /* waypoint */
		data_D154  =  154,      /* waypoint */
		data_D155  =  155,      /* waypoint */
		data_D200  =  200,      /* route header */
		data_D201  =  201,      /* route header */
		data_D202  =  202,      /* route header */
		data_D210  =  210,      /* route link */
		data_D300  =  300,      /* track point */
		data_D301  =  301,      /* track point */
		data_D302  =  302,      /* track point */
		data_D303  =  303,      /* track point */
		data_D304  =  304,      /* track point */
		data_D310  =  310,      /* track header */
		data_D311  =  311,      /* track header */
		data_D312  =  312,      /* track header */
		data_D400  =  400,      /* proximity waypoint */
		data_D403  =  403,      /* proximity waypoint */
		data_D450  =  450,      /* proximity waypoint */
		data_D500  =  500,      /* almanac */
		data_D501  =  501,      /* almanac */
		data_D550  =  550,      /* almanac */
		data_D551  =  551,      /* almanac */
		data_D600  =  600,      /* date/time */
		data_D601  =  601,      /* --- UNDOCUMENTED --- */
		data_D650  =  650,      /* flightbook record */
		data_D700  =  700,      /* position */
		data_D800  =  800,      /* position/velocity/time (PVT) */
		data_D801  =  801,      /* --- UNDOCUMENTED --- */
		data_D906  =  906,      /* lap */
		data_D907  =  907,      /* --- UNDOCUMENTED --- */
		data_D908  =  908,      /* --- UNDOCUMENTED --- */
		data_D909  =  909,      /* --- UNDOCUMENTED --- */
		data_D910  =  910,      /* --- UNDOCUMENTED --- */
		data_D1000 = 1000,      /* run */
		data_D1001 = 1001,      /* lap */
		data_D1002 = 1002,      /* workout */
		data_D1003 = 1003,      /* workout occurrence */
		data_D1004 = 1004,      /* fitness user profile */
		data_D1005 = 1005,      /* workout limits */
		data_D1006 = 1006,      /* course */
		data_D1007 = 1007,      /* course lap */
		data_D1008 = 1008,      /* workout */
		data_D1009 = 1009,      /* run */
		data_D1010 = 1010,      /* run */
		data_D1011 = 1011,      /* lap */
		data_D1012 = 1012,      /* course point */
		data_D1013 = 1013,      /* course limits */
		data_D1015 = 1015      /* lap */
	}
	
	public enum physical_protocol
	{
		P000 = 0
	}
	
	public enum link_protocol
	{
		L000 = 0,
		L001 = 1,
		L002 = 2
	}
	
	public enum application_protocol
	{
		appl_Anil  =    0,
		appl_A000  =    0,      /* product data protocol */
		appl_A001  =    1,      /* protocol capability protocol */
		appl_A010  =   10,      /* device command protocol 1 */
		appl_A011  =   11,      /* device command protocol 2 */
		appl_A100  =  100,      /* waypoint transfer protocol */
		appl_A101  =  101,      /* waypoint category transfer protocol */
		appl_A200  =  200,      /* route transfer protocol */
		appl_A201  =  201,      /* route transfer protocol */
		appl_A300  =  300,      /* track log transfer protocol */
		appl_A301  =  301,      /* track log transfer protocol */
		appl_A302  =  302,      /* track log transfer protocol */
		appl_A400  =  400,      /* proximity waypoint transfer protocol */
		appl_A500  =  500,      /* almanac transfer protocol */
		appl_A600  =  600,      /* date and time initialization protocol */
		appl_A601  =  601,      /* --- UNDOCUMENTED --- */
		appl_A650  =  650,      /* flightbook transfer protocol */
		appl_A700  =  700,      /* position initialization protocol */
		appl_A800  =  800,      /* PVT protocol */
		appl_A801  =  801,      /* --- UNDOCUMENTED --- */
		appl_A902  =  902,      /* --- UNDOCUMENTED --- */
		appl_A903  =  903,      /* --- UNDOCUMENTED --- */
		appl_A906  =  906,      /* lap transfer protocol */
		appl_A907  =  907,      /* --- UNDOCUMENTED --- */
		appl_A1000 = 1000,     /* run transfer protocol */
		appl_A1002 = 1002,     /* workout transfer protocol */
		appl_A1003 = 1003,     /* workout occurrence transfer protocol */
		appl_A1004 = 1004,     /* fitness user profile transfer protocol */
		appl_A1005 = 1005,     /* workout limits transfer protocol */
		appl_A1006 = 1006,     /* course transfer protocol */
		appl_A1007 = 1007,     /* course lap transfer protocol */
		appl_A1008 = 1008,     /* course point transfer protocol */
		appl_A1009 = 1009,     /* course limits transfer protocol */
		appl_A1012 = 1012     /* course track transfer protocol */
	}
	
	
}

