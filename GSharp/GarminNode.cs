using System;
using Gtk;
using GSharp.Protocols;

namespace GSharp
{
	[TreeNode (ListOnly=true)]
	public class GarminNode : Gtk.TreeNode
	{
		GarminUnit garmin;
		
		public GarminNode (GarminUnit Garmin)
		{
			this.garmin = Garmin;
			this.ID = garmin.ID.ToString("X2");
		}
		
		[TreeNodeValue (Column=0)]
		public string ID {get; private set;}
	}
}

