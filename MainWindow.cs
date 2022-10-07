using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow (string? windowName) : base (Gtk.WindowType.Toplevel)
	{
        Title = windowName;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}