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

        private readonly string owner;

        public CreditCard(string owner)
            // ˅
            
            // ˄
        {
            // ˅
            this.owner = owner;
            Console.WriteLine($"Make {this.owner}'s card.");
            // ˄
        }

        public void Use()
        {
            // ˅
            Console.WriteLine($"Use {this.owner}'s card.");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
