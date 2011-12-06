using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;


using Gtk;
using GSharp;
using GSharp.Protocols;
using GSharp.Data;

public partial class MainWindow: Gtk.Window
{	
	Gtk.TreeStore liststore;
	Garmin garminclass = Garmin.GetInstance();
	DataStore datastore = new DataStore();
	
	class TreeItemProperties
	{
		public String Name;
		public GarminUnit GarminUnit;
		public Gtk.TreePath Path;
		public Gtk.TreeIter Iter;
	}
	
	List<TreeItemProperties> garminnodes = new List<TreeItemProperties>();
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();		
		
		liststore = new Gtk.TreeStore(typeof(Gdk.Pixbuf), typeof(string));
		
		var idNameCell = new CellRendererText();
		idNameCell.Editable = true;
		idNameCell.Edited += (o, args) => {
			var editedargs = (Gtk.EditedArgs) args;
			TreeIter iter;
			liststore.GetIter(out iter, new TreePath(editedargs.Path));
			liststore.SetValue(iter,0,editedargs.NewText);
		};
		
		
		
		treeview2.AppendColumn("Icon", new CellRendererPixbuf(), "pixbuf", 0);
		treeview2.AppendColumn("ID", idNameCell, "text", 1);
		treeview2.AppendColumn("Notes", new CellRendererText(), "text", 2);
		treeview2.Selection.Mode = SelectionMode.Single;
		garminclass.DeviceAdded = HandleDeviceAttach;
	}

	void HandleDeviceAttach (GarminUnit obj)
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
	}

	protected void OnQuitActionActivated (object sender, System.EventArgs e)
	{
		Application.Quit();
	}

	protected void OnFindActionActivated (object sender, System.EventArgs e)
	{
		foreach ( var garmin in garminclass.GarminUnits )
		{
			var garmin_id = garmin.ID.ToString("X2");
			
			if ( garminnodes.Where(n => n.Name == garmin_id).Count() > 0 )
				continue;
			
			if ( !datastore.ContainsGarmin((int) garmin.ID) )
			{
				datastore.InsertGarmin((int) garmin.ID, garmin_id);
			}
			else
			{
				garmin_id = datastore.GetGarminName((int) garmin.ID);
			}
			
			var a = Assembly.GetExecutingAssembly();
			var rs = a.GetManifestResourceStream("GSharp.icons.ForeRunner305.png");
			var image = new Gdk.Pixbuf(rs).AddAlpha(true,64,255,64);
			var iter = liststore.AppendValues(image, garmin_id);
			
			garminnodes.Add(new TreeItemProperties() {
				Name = garmin_id,
				GarminUnit = garmin,
				Path = liststore.GetPath(iter),
				Iter = iter
			});
			
//			GarminUnitIters.Add(garmin_id, iter);
//			GarminDevices.Add(garmin_id, garmin);
			
			
//			if ( datastore.GetGarminName((int) garmin.ID) == string.Empty )
//			{
//				var md = new MessageDialog(this, DialogFlags.Modal, MessageType.Info,
//					ButtonsType.YesNo, "New garmin device {0} found. Do you wish to add it?", garmin.ID.ToString("X2"));
//				ResponseType response = (ResponseType) md.Run();
//				if ( response == ResponseType.Yes )
//				{
//				}
//				md.Destroy();
//			}
		}
		
		treeview2.Model = liststore;
	}

	protected void OnRefreshActionActivated (object sender, System.EventArgs e)
	{
		var paths = treeview2.Selection.GetSelectedRows();
		if ( paths.Length == 1)
		{
			var node = garminnodes.Where(n => n.Path == paths[0]).First();
			
			foreach ( var run in node.GarminUnit.GetRuns())
			{
				if ( !datastore.ContainsRun(node.GarminUnit, run) )
				{
					datastore.AddRun(node.GarminUnit, run);
				}
			}
			
			foreach ( var lap in node.GarminUnit.GetLaps() )
			{
				if ( !datastore
			}
		}
	}
}
