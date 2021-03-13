// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Memento
{
    public class Gamer
    {
        // ˅
        
        // ˄

        // Gamer's money
        public int Money
        {
            // ˅
            get; private set;
            // ˄
        }

        // Random number generator
        private readonly Random random;

        public Gamer(int money)
            // ˅
            
            // ˄
        {
            // ˅
            Money = money;
            random = new Random();
            
            // ˄
        }

        public Memento CreateMemento()
        {
            // ˅
            return new Memento(Money);
            // ˄
        }

        public void SetMemento(Memento memento)
        {
            // ˅
            Money = memento.Money;
            // ˄
        }

        // Play a game
        public void Play()
        {
            // ˅
            int dice = random.Next(6) + 1;  // Shake a dice
            Console.WriteLine($"The number of dice is {dice}.");

            int preMoney = Money;
            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    // In case of odd...Money is halved
                    Money /= 2;
                    Console.WriteLine($"Gamer's money is halved: {preMoney} -> {Money}");
                    break;
                case 2:
                case 4:
                case 6:
                    // In case of even...Money doubles
                    Money *= 2;
                    Console.WriteLine($"Gamer's money doubles: {preMoney} -> {Money}");
                    break;
                default:
                    // Other...Exit
                    Console.Error.WriteLine("Unexpected value.");
                    Environment.Exit(1);
                    break;
            }
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"[money = {Money}]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
