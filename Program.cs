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
			
			VBox boxofVert = new VBox(false, 0);


			boxofVert.PackStart(bob.status, true, true, 5);
			boxofVert.PackStart(button1, true, true, 5);
			boxofVert.PackStart(bob.entryfield, true,true, 5);
			
			Widget widBox = boxofVert;
			
			
			bob.win.Add(widBox);
			
			

			bob.win.ShowAll();
			
			Application.Run ();
			

			
		}
		
	}
}