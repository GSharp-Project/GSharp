using System;
using Gtk;
using GSharp;
using GSharp.Protocols;
using GSharp.Data;

public partial class MainWindow: Gtk.Window
{	
	//Gtk.ListStore liststore;
	Gtk.TreeStore liststore;
	Garmin garminclass = Garmin.GetInstance();
	DataStore datastore = new DataStore();
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		//liststore = new Gtk.ListStore(typeof(string));
		liststore = new Gtk.TreeStore(typeof(string));
		treeview2.AppendColumn("ID", new CellRendererText(), "text", 0);
		treeview2.AppendColumn("Notes", new CellRendererText(), "text", 1);
		garminclass.DeviceAdded = HandleGarminclass;
	}

	void HandleGarminclass (GarminUnit obj)
	{
		var md = new MessageDialog(this, DialogFlags.Modal, MessageType.Info,
			ButtonsType.Ok, "{0}", obj.ID);
		md.Run();
		md.Destroy();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnExecuteActionActivated (object sender, System.EventArgs e)
	{
//		Garmin g = Garmin.GetInstance();
//		foreach ( var garmin in g.GarminUnits )
//		{
//			var iter = liststore.AppendValues(garmin.ID.ToString("X2"));
//			var runs = garmin.GetRuns();
//			runs.Reverse();
//			foreach ( var run in runs )
//			{
//				liststore.AppendValues(iter, run.TrackIndex.ToString());
//			}
//		}
		
		treeview2.Model = liststore;
		
//		nodeview1.NodeStore = nodestore;
//		nodeview1.AppendColumn("ID", new CellRendererText(), "text", 0);
//		nodeview1.ShowAll();
	}

	protected void OnQuitActionActivated (object sender, System.EventArgs e)
	{
		Application.Quit();
	}

	protected void OnFindActionActivated (object sender, System.EventArgs e)
	{
		foreach ( var garmin in garminclass.GarminUnits )
		{
			if ( datastore.GetGarminName((int) garmin.ID) == string.Empty )
			{
				var md = new MessageDialog(this, DialogFlags.Modal, MessageType.Info,
					ButtonsType.YesNo, "New garmin device {0} found. Do you wish to add it?", garmin.ID.ToString("X2"));
				ResponseType response = (ResponseType) md.Run();
				if ( response == ResponseType.Yes )
				{
				}
				md.Destroy();
			}
		}
	}
}
