// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.FactoryMethod.Framework;

// ˄

namespace CreationalPatterns.FactoryMethod.CreditCard
{
    public class CreditCardFactory : Factory
    {
        // ˅
        
        // ˄

        public CreditCardFactory()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        public override IProduct CreateProduct(string owner)
        {
            // ˅
            return new CreditCard(owner);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
