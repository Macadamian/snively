
// This file has been generated by the GUI designer. Do not modify.
namespace Snively
{
	public partial class NoteEditor
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Entry entry1;
		private global::Gtk.HBox hbox4;
		private global::Gtk.ScrolledWindow NoteContentsScrolledWindow;
		private global::Gtk.TextView NoteContentsEdit;
		private global::Gtk.ScrolledWindow NoteChildrenScrolledWindow;
		private global::Gtk.TreeView NoteChildrenTreeView;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Snively.NoteEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Snively.NoteEditor";
			// Container child Snively.NoteEditor.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.vbox1.Add (this.entry1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.NoteContentsScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.NoteContentsScrolledWindow.Name = "NoteContentsScrolledWindow";
			this.NoteContentsScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child NoteContentsScrolledWindow.Gtk.Container+ContainerChild
			this.NoteContentsEdit = new global::Gtk.TextView ();
			this.NoteContentsEdit.CanFocus = true;
			this.NoteContentsEdit.Name = "NoteContentsEdit";
			this.NoteContentsScrolledWindow.Add (this.NoteContentsEdit);
			this.hbox4.Add (this.NoteContentsScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.NoteContentsScrolledWindow]));
			w3.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.NoteChildrenScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.NoteChildrenScrolledWindow.Name = "NoteChildrenScrolledWindow";
			this.NoteChildrenScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child NoteChildrenScrolledWindow.Gtk.Container+ContainerChild
			this.NoteChildrenTreeView = new global::Gtk.TreeView ();
			this.NoteChildrenTreeView.CanFocus = true;
			this.NoteChildrenTreeView.Name = "NoteChildrenTreeView";
			this.NoteChildrenTreeView.Reorderable = true;
			this.NoteChildrenScrolledWindow.Add (this.NoteChildrenTreeView);
			this.hbox4.Add (this.NoteChildrenScrolledWindow);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.NoteChildrenScrolledWindow]));
			w5.Position = 1;
			this.vbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
			w6.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}