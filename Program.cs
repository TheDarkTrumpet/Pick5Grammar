using System;
using Pick5Grammar.src;

namespace Pick5Grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel excel = new Excel("Example.xlsx", args.Length > 0 ? int.Parse(args[0]) : 5);
        }
    }
}
