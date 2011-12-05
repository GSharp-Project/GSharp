using System;
using Gtk;
using GSharp.Protocols;

namespace GSharp
{
	[TreeNode (ListOnly=true)]
	public class LapNode
	{
		Lap lap;
		
		public LapNode (Lap Lap)
		{
			this.lap = Lap;
		}
		
		[TreeNodeValue (Column=0)]
		public string StartTime { get { return lap.StartTime.ToShortTimeString(); } }
	}
}

