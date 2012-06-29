using System;
using Gtk;
using MindTouch.Tasking;
using DreamSeat;
using Snively;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		var couchClient = new DreamSeat.CouchClient("localhost", 5984);
		couchClient.GetDatabase ("explosions",  new Result<CouchDatabase>()).WhenDone((database) => {
			Console.Out.WriteLine("SUCCESS!");
		}, e => {
			Console.Out.WriteLine ("Failure! :( " +  e.Message);
		});

        var editor = new NoteEditor();

        this.notebook1.Add(editor);
        editor.Show();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
