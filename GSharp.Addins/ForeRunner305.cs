using System;
using System.Collections.Generic;
using GSharp.Protocols;
using LibUsbDotNet;
using Mono.Addins;

namespace GSharp.Addins
{
	[Extension]
	public class ForeRunner305 : IGarminUnit
	{
		private const int vid = 0x91e;
		private const int pid = 0x003;
		
		public ForeRunner305 ()
		{
		}
		
		public string Description { get { return "Garmin Forerunner 305"; } }
		public int VID { get { return vid; } }
		public int PID { get { return pid; } }
	}
}

