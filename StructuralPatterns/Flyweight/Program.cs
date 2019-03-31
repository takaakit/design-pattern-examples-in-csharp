using System;

// First, create instances for displaying large size characters, then display large size character string using that instances.

namespace StructuralPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: dotnet Flyweight.dll digits");
                Console.WriteLine("Ex.  : dotnet Flyweight.dll 1212123");
            }
            else
            {
                var bs = new LargeSizeString(args[0]);
                bs.Display();
            }
        }
    }
}
