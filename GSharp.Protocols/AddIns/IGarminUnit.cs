using System;
using System.Collections.Generic;
using Mono.Addins;
using LibUsbDotNet;

namespace GSharp.Protocols
{
	[TypeExtensionPoint]
	public interface IGarminUnit
	{
		string Description {get;}
		int VID {get;}
		int PID {get;}
	}
}

