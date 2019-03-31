using System;

// At the time of printing, create an instance of the printer for the first time.
// In order to spend time creating a printer, call a heavy task when creating a printer instance.

namespace StructuralPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PrinterProxy("Emily's printer");
            Console.WriteLine($"The current printer is {p.PrinterName}.");
            p.PrinterName = "William's printer";
            Console.WriteLine($"The current printer is {p.PrinterName}.");
            p.Output("Nice to meet you.");
        }
    }
}
