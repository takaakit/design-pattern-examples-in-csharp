using System;

/*
A game of rock-scissors-paper. Two strategies are available:
* Random Strategy: showing a random hand signal.
* Mirror Strategy: showing a hand signal from the previous opponent's hand signal.
 */

namespace BehavioralPatterns.Strategy
{
    class Program
    {
        static void Main()
        {
            Player player1 = new Player("Emily", new RandomStrategy());
            Player player2 = new Player("James", new MirrorStrategy());

            for (var i = 0; i < 100; i++)
            {
                HandSignal handOfPlayer1 = player1.ShowHandSignal();
                HandSignal handOfPlayer2 = player2.ShowHandSignal();

                // Judge win, loss, or draw
                GameResultType resultOfPlayer1;
                GameResultType resultOfPlayer2;
                if (handOfPlayer1.IsStrongerThan(handOfPlayer2))
                {
                    Console.WriteLine($"Winner: {player1}");
                    resultOfPlayer1 = GameResultType.Win;
                    resultOfPlayer2 = GameResultType.Loss;
                }
                else if (handOfPlayer2.IsStrongerThan(handOfPlayer1))
                {
                    Console.WriteLine($"Winner: {player2}");
                    resultOfPlayer1 = GameResultType.Loss;
                    resultOfPlayer2 = GameResultType.Win;
                }
                else
                {
                    Console.WriteLine("Draw...");
                    resultOfPlayer1 = GameResultType.Draw;
                    resultOfPlayer2 = GameResultType.Draw;
                }

                player1.NotifyGameResult(resultOfPlayer1, handOfPlayer1, handOfPlayer2);
                player2.NotifyGameResult(resultOfPlayer2, handOfPlayer2, handOfPlayer1);
            }
            Console.WriteLine("RESULT:");
            Console.WriteLine(player1);
            Console.WriteLine(player2);
        }
    }
}
