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

        // Acquired desserts 
        private List<string> desserts;

        // Random number generator
        private readonly Random random;

        // Dessert name table
        private static readonly string[] dessertsName = { "Cake", "Candy", "Cookie" };

        // Get a dessert
        public string Dessert
        {
            // ˅
            get
            {
                var prefix = "";
                if ((int)(random.Next(2)) == 0)
                {
                    prefix = "Delicious ";
                }
                return prefix + dessertsName[(int)(random.Next(dessertsName.Length))];
            }
            // ˄
        }

        public Gamer(int money)
            // ˅
            
            // ˄
        {
            // ˅
            this.desserts = new List<String>();
            this.random = new Random();
            Money = money;
            
            // ˄
        }

        // Get current status
        public Memento CreateMemento()
        {
            // ˅
            Memento memento = new Memento(Money);
            foreach (string dessert in dessertsName)
            {
                if (dessert.StartsWith("Delicious "))   // Add a only delicious dessert
                {
                    memento.AddDessert(dessert);
                }
            }
            return memento;
            // ˄
        }

        // Undo status
        public void RestoreMemento(Memento memento)
        {
            // ˅
            this.Money = memento.money;
            this.desserts = memento.desserts;
            // ˄
        }

        // Play a game
        public void Play()
        {
            // ˅
            var dice = random.Next(6) + 1;  // Shake a dice
            switch (dice)
            {
                case 1:  // In case of 1...Gamer's money increases
                    Money += 100;
                    Console.WriteLine("Gamer's money increases.");
                    break;
                case 2:  // In case of 2...Gamer's money halves
                    Money /= 2;
                    Console.WriteLine("Gamer's money halves.");
                    break;
                case 6:  // In case of 6...Gamer gets desserts
                    var acquiredDessert = Dessert;
                    Console.WriteLine($"Gamer gets desserts({acquiredDessert})");
                    desserts.Add(acquiredDessert);
                    break;
                default: // Other...Nothing happens
                    Console.WriteLine("Nothing happens.");
                    break;
            }
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"[money = {Money}, desserts = {string.Join(", ", desserts)}]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
