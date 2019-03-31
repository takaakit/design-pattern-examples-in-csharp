// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Memento
{
    public class Memento
    {
        // ˅
        
        // ˄

        // Money
        internal int money;

        // Desserts
        internal List<string> desserts;

        public Memento(int money)
            // ˅
            
            // ˄
        {
            // ˅
            this.money = money;
            this.desserts = new List<string>();
            
            // ˄
        }

        // Add a dessert
        internal void AddDessert(string dessert)
        {
            // ˅
            desserts.Add(dessert);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
