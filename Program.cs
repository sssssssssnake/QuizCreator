using System;
using Gtk;

namespace QuizGeneratevscode
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			
			Application.Init ();
			Window win = new Window("Quiz Constructor");
			
			Label status = new Label();
			status.Text = "helloagain";
			Button button1 = Button.NewWithMnemonic("Hello World");
			
			HBox box = new HBox(false, 0);

			box.PackStart(status, true, true, 1);
			box.PackStart(button1, true, true, 1);
			status.Show();
			button1.Show();
			Widget widBox = box;
			box.Show();
			widBox.Show();
			
			win.Add(widBox);
			
			
			win.ShowAll();
			
            
			Application.Run ();
			

			
		}
		
	}
}