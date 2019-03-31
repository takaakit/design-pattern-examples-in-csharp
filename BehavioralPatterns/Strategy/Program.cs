using System;

/*
A game of rock-scissors-paper.
There are two strategies below.

* When winning a game, show the same hand at the next time.
* Calculate a hand from the previous hand stochastically.
*/

namespace BehavioralPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: dotnet Strategy.dll RandomSeedNumber1 RandomSeedNumber2");
                Console.WriteLine("Ex.  : dotnet Strategy.dll 314 15");
            }
            else
            {
                int randomSeed1 = int.Parse(args[0]);
                int randomSeed2 = int.Parse(args[1]);
                var player1 = new Player("Emily", new StrategyA(randomSeed1));
                var player2 = new Player("James", new StrategyB(randomSeed2));

                for (var i = 0; i < 100; i++)
                {
                    var nextHand1 = player1.NextHand();
                    var nextHand2 = player2.NextHand();
                    if (nextHand1.IsStrongerThan(nextHand2))
                    {
                        Console.WriteLine($"Winner: {player1}");
                        player1.Won();
                        player2.Lost();
                    }
                    else if (nextHand2.IsStrongerThan(nextHand1))
                    {
                        Console.WriteLine($"Winner: {player2}");
                        player1.Lost();
                        player2.Won();
                    }
                    else
                    {
                        Console.WriteLine("Draw...");
                        player1.Drew();
                        player2.Drew();
                    }
                }
                Console.WriteLine("RESULT:");
                Console.WriteLine(player1);
                Console.WriteLine(player2);
            }
        }
    }
}
