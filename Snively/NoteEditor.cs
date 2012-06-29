using System;

namespace Snively
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class NoteEditor : Gtk.Bin
    {
        public NoteEditor()
        {
            this.Build();

            var store = new Gtk.ListStore(typeof(string), typeof(string));

            store.AppendValues("gtk-edit", "no, you are the fuel");

            var column = new Gtk.TreeViewColumn();

            var iconRenderer = new Gtk.CellRendererPixbuf();

            column.PackStart(iconRenderer, false);
            column.AddAttribute(iconRenderer, "stock-id", 0);

            var textRenderer = new Gtk.CellRendererText();

            column.PackStart(textRenderer, true);
            column.AddAttribute(textRenderer, "text", 1);

            NoteChildrenTreeView.Model = store;

            NoteChildrenTreeView.AppendColumn(column);

            // http://www.mono-project.com/GtkSharp_TreeView_Tutorial
            // http://afaikblog.files.wordpress.com/2012/05/edit-item1.png
            // http://james.newtonking.com/projects/json/help/
            // http://mono.1490590.n4.nabble.com/NodeView-TreeView-Image-and-Text-into-the-same-column-td1546566.html

            // OKAY, I NEED TO DECIDE HOW I AM GOING TO BIND THINGS

            // I definitely want a ViewModel.
        }
    }
}

