// ˅
using System;

// ˄

namespace StructuralPatterns.Proxy
{
    public class RealPrinter : IPrinter
    {
        // ˅
        
        // ˄

        private string name;

        public RealPrinter(string name)
            // ˅
            
            // ˄
        {
            // ˅
            this.name = name;
            HeavyTask($"Creating an instance ({name}) of the Printer");
            // ˄
        }

        public string GetName()
        {
            // ˅
            return name;
            // ˄
        }

        public void ChangeName(string name)
        {
            // ˅
            this.name = name;
            // ˄
        }

        // Display a content with the name
        public void Output(string content)
        {
            // ˅
            Console.WriteLine("==========");
            Console.WriteLine(content);
            Console.WriteLine($"Printed by {name}");
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
