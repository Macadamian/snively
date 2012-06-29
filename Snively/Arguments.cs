using System;
using CommandLine;
using CommandLine.Text;

namespace Snively
{
    public class Arguments : CommandLineOptionsBase 
    {
        [Option("i", "install-db", Required = false, DefaultValue = false,
        HelpText = "Install design documents into the CouchDB database")]
        public bool InstallDB { get; set; }

//        [Option("c", "start-console", Required = false, DefaultValue = false,
//        HelpText = "Start the REPL")]
//        public bool StartREPL { get; set; }

        [Option("g", "start-gui", Required = false, DefaultValue = true,
        HelpText = "Start the GTK GUI")]
        public bool StartGUI { get; set; }

        [Option("d", "database-name", Required = false, DefaultValue = "snively",
        HelpText = "Specify the name of the CouchDB database")]
        public String DatabaseName { get; set; }

        [HelpOption]
      public string GetUsage() {
        return HelpText.AutoBuild(this,
            (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
      }
    }
}
