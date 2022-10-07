using System;
using Gtk;

class bob
{
    public static MainWindow win = new MainWindow("Quiz Constructor");
    public static string lblText = "Are You Ready?";

    public static Label status = new Gtk.Label();
	
    public static void calling(object obj, EventArgs eventArgs) {
        lblText = "Good";
        winAndLblShow();
    }
    public static void winAndLblShow() {
        status.Text = lblText;
        status.Show();
        win.ShowAll();
    }
    
}