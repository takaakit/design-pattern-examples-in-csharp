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
            printerName = name;
            HeavyTask($"Creating an instance ({name}) of the Printer");
            // ˄
        }

        // Display a content with the name
        public void Output(string content)
        {
            // ˅
            Console.WriteLine("==========");
            Console.WriteLine(content);
            Console.WriteLine($"Printed by {printerName}");
            Console.WriteLine("==========");
            // ˄
        }

        // Heavy task (Please think so...)
        private void HeavyTask(string message)
        {
            // ˅
            Console.Write(message);
            for (int i = 0; i < 10; i++)
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
