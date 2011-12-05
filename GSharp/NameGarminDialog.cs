using System;

namespace GSharp
{
	public partial class NameGarminDialog : Gtk.Window
	{
		public NameGarminDialog () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Modal = true;
		}

		protected void OnButton2Clicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnButton1Clicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
		
		
	}
}

