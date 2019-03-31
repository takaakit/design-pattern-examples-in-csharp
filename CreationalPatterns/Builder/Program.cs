using System;

// Create documents in HTML format and text format.

namespace CreationalPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                ShowUsage();
            }
            else if (args[0] == "plain")
            {
                var plainTextBuilder = new PlainTextBuilder();
                var director = new Director(plainTextBuilder);
                director.Build();
                var content = plainTextBuilder.Result;
                Console.WriteLine(content);
            }
            else if (args[0] == "html")
            {
                var htmlBuilder = new HTMLBuilder();
                var director = new Director(htmlBuilder);
                director.Build();
                var filename = htmlBuilder.Result;
                Console.WriteLine($"{filename} has been created.");
            }
            else
            {
                ShowUsage();
            }
        }

        private static void ShowUsage()
        {
            Console.WriteLine("Usage 1: dotnet Builder.dll plain      <- Create a document in plain text.");
            Console.WriteLine("Usage 2: dotnet Builder.dll html       <- Create a document in HTML.");
        }
    }
}
