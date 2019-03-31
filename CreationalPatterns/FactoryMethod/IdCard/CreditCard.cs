// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.FactoryMethod.Framework;

// ˄

namespace CreationalPatterns.FactoryMethod.IdCard
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

        internal CreditCard(string owner)
            // ˅
            
            // ˄
        {
            // ˅
            Console.WriteLine($"Make {owner}'s card.");
            this.Owner = owner;
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
