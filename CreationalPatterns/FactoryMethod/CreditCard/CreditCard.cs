// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.FactoryMethod.Framework;

// ˄

namespace CreationalPatterns.FactoryMethod.CreditCard
{
    public class CreditCard : IProduct
    {
        // ˅
        
        // ˄

        public string Owner
        {
            // ˅
            get; private set;
            // ˄
        }

        public CreditCard(string owner)
            // ˅
            
            // ˄
        {
            // ˅
            Owner = owner;
            Console.WriteLine($"Make {Owner}'s card.");
            // ˄
        }

        public void Use()
        {
            // ˅
            Console.WriteLine($"Use {Owner}'s card.");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
