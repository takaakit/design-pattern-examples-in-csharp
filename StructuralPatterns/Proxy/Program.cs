using System;

/*
Print on a named printer. Setting and changing the printer name is done by Proxy (PrinterProxy).
At the time of printing, create an instance of the RealSubject (RealPrinter) for the first time.
 */

namespace StructuralPatterns.Proxy
{
    class Program
    {
        static void Main()
        {
            PrinterProxy p = new PrinterProxy("PRINTER-A");
            Console.WriteLine($"The printer name is {p.PrinterName}.");
            p.PrinterName = "PRINTER-B";
            Console.WriteLine($"The printer name is {p.PrinterName}.");

            Console.WriteLine("Print start.");
            p.Output("Nice to meet you.");
            Console.WriteLine("Print exit.");
        }
    }
}
