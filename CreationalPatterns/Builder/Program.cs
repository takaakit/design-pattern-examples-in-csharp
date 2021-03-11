using System;
using System.IO;

/*
Create documents in HTML format and text format. It is possible to create different documents
in the same construction process.
 */

namespace CreationalPatterns.Builder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter \"plain\" or \"html\":");
            string inputValue = Console.ReadLine();

            if (inputValue == "plain")
            {
                PlainTextBuilder plainTextBuilder = new PlainTextBuilder();
                Director director = new Director(plainTextBuilder);
                director.Build();
                string content = plainTextBuilder.Content;
                Console.WriteLine(content);
            }
            else if (inputValue == "html")
            {
                HTMLBuilder htmlBuilder = new HTMLBuilder();
                Director director = new Director(htmlBuilder);
                director.Build();
                string fileName = htmlBuilder.FileName;
                Console.WriteLine($"{fileName} has been created.");
                Console.WriteLine($"Output File: {Path.Combine(System.Environment.CurrentDirectory, fileName)}");
            }
            else
            {
                Console.Error.WriteLine("The value is not \"plain\" or \"html\".");
                Environment.Exit(1);
            }
        }
    }
}
