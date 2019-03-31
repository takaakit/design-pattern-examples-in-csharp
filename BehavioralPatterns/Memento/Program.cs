using System;

/*
Dice game collecting fruits.

* A gamer shakes a dice and the number determine the next state.
* Gamer's money increases or decreases depending on the number. The gamer sometimes gets desserts.
* The game is over if the gamer's money runs out.
*/

namespace BehavioralPatterns.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamer = new Gamer(100);               // The initial money is 100
            var memento = gamer.CreateMemento();      // Save the initial state

            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine($"==== {i}");                 // Display count
                Console.WriteLine($"Current state: {gamer}");   // Display the current state of the gamer

                gamer.Play();                                   // Play a game

                Console.WriteLine($"Gamer's money is {gamer.Money}.");

                // Determine the behavior of the Memento
                if (gamer.Money > memento.money)
                {
                    Console.WriteLine("(Save the current state because money has increased.)");
                    memento = gamer.CreateMemento();
                }
                else if (gamer.Money < memento.money / 2)
                {
                    Console.WriteLine("(Go back to the previous state because money has decreased.)");
                    gamer.RestoreMemento(memento);
                }

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("");
            }
        }
    }
}
