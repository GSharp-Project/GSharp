using System;
using Gtk;
using GSharp.Protocols;

namespace GSharp
{
	[TreeNode (ListOnly=true)]
	public class RunNode : Gtk.TreeNode
	{
		Run		run;
		
		public RunNode (Run Run)
		{
			this.run = Run;
			this.foo = run.TrackIndex.ToString();
		}
		
		[TreeNodeValue (Column=0)]
		public string foo {get; private set;}
	}
}

