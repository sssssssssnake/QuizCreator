using System;
using Gtk;

namespace QuizGeneratevscode
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			
			Application.Init ();
			
			
			bob.status.Text = bob.lblText;
			Button button1 = Button.NewWithMnemonic("Hello World");
			button1.Clicked += bob.calling;
			
			VBox box = new VBox(false, 0);

			box.PackStart(bob.status, true, true, 1);
			box.PackStart(button1, true, true, 1);
			
			Widget widBox = box;
			
			
			bob.win.Add(widBox);
			
			
			bob.win.ShowAll();
			
			Application.Run ();
			

			
		}
		
	}
}