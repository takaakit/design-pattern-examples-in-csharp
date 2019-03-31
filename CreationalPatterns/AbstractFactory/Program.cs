using System;
using CreationalPatterns.AbstractFactory.BaseFactory;

// Create a hierarchical link collection as an HTML file.

namespace CreationalPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: dotnet AbstractFactory.dll class.name.of.ConcreteFactory");
                Console.WriteLine("Ex.1 : dotnet AbstractFactory.dll CreationalPatterns.AbstractFactory.ListFactory.ListFactory");
                Console.WriteLine("Ex.2 : dotnet AbstractFactory.dll CreationalPatterns.AbstractFactory.TableFactory.TableFactory");
            }
            else
            {
                var factory = Factory.GetFactory(args[0]);

                var washingtonPost = factory.CreateLink("The Washington Post", "https://www.washingtonpost.com/");
                var newYorkTimes = factory.CreateLink("The NewYork Times", "https://www.nytimes.com/");
                var financialTimes = factory.CreateLink("The Financial Times", "https://www.ft.com/");
                var yahoo = factory.CreateLink("Yahoo!", "https://www.yahoo.com/");
                var google = factory.CreateLink("Google", "https://www.google.com/");
                var mlb = factory.CreateLink("MLB", "https://www.mlb.com/");
                var fifa = factory.CreateLink("FIFA", "https://www.fifa.com/");
                var wba = factory.CreateLink("WBA", "http://www.wbaboxing.com/");
                var wbc = factory.CreateLink("WBC", "http://www.wbcboxing.com/");

                var newspaper = factory.CreateData("Newspaper");
                newspaper.Add(washingtonPost);
                newspaper.Add(newYorkTimes);
                newspaper.Add(financialTimes);

                var searchEngine = factory.CreateData("Search engine");
                searchEngine.Add(yahoo);
                searchEngine.Add(google);

                var sports = factory.CreateData("Sports");
                sports.Add(mlb);
                sports.Add(fifa);
                sports.Add(wba);
                sports.Add(wbc);

                var linkPage = factory.CreatePage("LinkPage", "James Smith");
                linkPage.Add(newspaper);
                linkPage.Add(searchEngine);
                linkPage.Add(sports);

                linkPage.Output();
            }
        }
    }
}
