using System;

/*
Print on a named printer. Setting and changing the printer name is done by Proxy (ProxyPrinter).
At the time of printing, create an instance of the RealSubject (RealPrinter) for the first time.
 */

namespace StructuralPatterns.Proxy
{
    class Program
    {
        static void Main()
        {
            ProxyPrinter p = new ProxyPrinter("PRINTER-A");
            Console.WriteLine($"The printer name is {p.GetName()}.");
            p.ChangeName("PRINTER-B");
            Console.WriteLine($"The printer name is {p.GetName()}.");

            Console.WriteLine("Print start.");
            p.Output("Nice to meet you.");
            Console.WriteLine("Print exit.");
        }
    }
}
