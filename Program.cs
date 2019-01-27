using System;
using Pick5Grammar.src;
using CommandLine;
using System.Collections.Generic;

namespace Pick5Grammar
{
    class Program
    {
        class Options
        {
            [Option('i', "input", Required = true, HelpText = "Input xlsx file")]
            public string InputFile {get; set; }

            [Option('c', "count", Required=false, HelpText="Number of random entries to receive")]
            public int randomEntries {get; set; } = 5;
        }
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(opts => ExecutePick5(opts));
        }

        static void ExecutePick5(Options options)
        {
            Excel excel = new Excel(options.InputFile, options.randomEntries);
        }
    }
}
