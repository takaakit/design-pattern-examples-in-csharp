// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Proxy
{
    public class RealPrinter : IPrinter
    {
        // ˅
        
        // ˄

        public string printerName;

        public RealPrinter(string name)
            // ˅
            
            // ˄
        {
            // ˅
            this.printerName = name;
            HeavyTask($"Creating an instance({name}) of the Printer");
            // ˄
        }

        // Display a content with the name
        public void Output(string content)
        {
            // ˅
            Console.WriteLine($"=== {printerName} ===");
            Console.WriteLine(content);
            // ˄
        }

        // Heavy task (Please think so...)
        private void HeavyTask(string message)
        {
            // ˅
            Console.Write(message);
            for (var i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine("Done.");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
