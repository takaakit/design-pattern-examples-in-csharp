using System;

/*
A dice game in which money increases and decreases:
* A gamer shakes a dice and the number determine the next state.
* If the number of dice is even, gamer's money doubles, and if it is odd, gamer's money is halved.
* If the gamer's money is less than half of the highest amount, it returns to the highest amount.
* The game is repeated.
 */

namespace BehavioralPatterns.Memento
{
    class Program
    {
        static void Main()
        {
            Gamer gamer = new Gamer(100);               // The initial money is 100
            Memento memento = gamer.CreateMemento();    // Save the initial state

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"==== Turn {i + 1}");    // Display count

                gamer.Play();                               // Play a game

                Console.WriteLine($"Gamer's money is {gamer.Money}.");

                // Determine the behavior of the Memento
                if (gamer.Money > memento.Money)
                {
                    Console.WriteLine("(Gamers' money is the highest ever, so record the current state.)");
                    memento = gamer.CreateMemento();
                }
                else if (gamer.Money < memento.Money / 2)
                {
                    Console.WriteLine("(Gamer's money is less than half of the highest amount, so return to the recorded state.)");
                    gamer.SetMemento(memento);
                    Console.WriteLine($"Gamer's money returns to {gamer.Money}.");
                }

                Console.WriteLine();

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
