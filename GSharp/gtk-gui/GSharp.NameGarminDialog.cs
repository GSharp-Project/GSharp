
// This file has been generated by the GUI designer. Do not modify.
namespace GSharp
{
	public partial class NameGarminDialog
	{
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Button button2;
		private global::Gtk.Label label1;
		private global::Gtk.Button button1;
		private global::Gtk.Entry entry1;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget GSharp.NameGarminDialog
			this.Name = "GSharp.NameGarminDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Give your garmin a name");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child GSharp.NameGarminDialog.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
			this.fixed1.Add (this.button2);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button2]));
			w1.X = 221;
			w1.Y = 87;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.fixed1.Add (this.label1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
			w2.X = 56;
			w2.Y = 34;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("OK");
			this.fixed1.Add (this.button1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button1]));
			w3.X = 182;
			w3.Y = 86;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed1.Add (this.entry1);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
			w4.X = 116;
			w4.Y = 27;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 388;
			this.DefaultHeight = 166;
			this.Show ();
			this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
			this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
		}
	}
}
