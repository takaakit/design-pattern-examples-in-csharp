using System;
using CreationalPatterns.AbstractFactory.Factory;

/*
Create a hierarchical link collection as an HTML file. It can be created in either tabular or list format.
 */

namespace CreationalPatterns.AbstractFactory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number (1 or 2):");
            Console.WriteLine("  1: Create objects by using ListFactory");
            Console.WriteLine("  2: Create objects by using TableFactory");
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Error.WriteLine("Unexpected value.");
                Environment.Exit(1);
            }

            IFactory factory = null;
            if (number == 1)
            {
                factory = new ListFactory.ListFactory();
            }
            else if (number == 2)
            {
                factory = new TableFactory.TableFactory();
            }
            else
            {
                Console.Error.WriteLine("The value is not 1 or 2.");
                Environment.Exit(1);
            }

            Link washingtonPost = factory.CreateLink("The Washington Post", "https://www.washingtonpost.com/");
            Link newYorkTimes = factory.CreateLink("The NewYork Times", "https://www.nytimes.com/");
            Link financialTimes = factory.CreateLink("The Financial Times", "https://www.ft.com/");

            Data newspaper = factory.CreateData("Newspaper");
            newspaper.Add(washingtonPost);
            newspaper.Add(newYorkTimes);
            newspaper.Add(financialTimes);

            Link yahoo = factory.CreateLink("Yahoo!", "https://www.yahoo.com/");
            Link google = factory.CreateLink("Google", "https://www.google.com/");

            Data searchEngine = factory.CreateData("Search engine");
            searchEngine.Add(yahoo);
            searchEngine.Add(google);

            Page linkPage = factory.CreatePage("LinkPage", "James Smith");
            linkPage.Add(newspaper);
            linkPage.Add(searchEngine);

            linkPage.Output();
        }
    }
}
