using System;
using Gtk;
using CommandLine;

namespace Snively
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            var arguments = new Arguments();
            if(CommandLineParser.Default.ParseArguments(args, arguments)) {
                if(arguments.InstallDB) {
                }
            } else {
                Console.Out.WriteLine("Invalid arguments.");
            }
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
