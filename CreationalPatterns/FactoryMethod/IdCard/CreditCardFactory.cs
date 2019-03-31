// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.FactoryMethod.Framework;

// ˄

namespace CreationalPatterns.FactoryMethod.IdCard
{
    public class CreditCardFactory : Factory
    {
        // ˅
        
        // ˄

        private List<string> cardOwners;

        public CreditCardFactory()
            // ˅
            
            // ˄
        {
            // ˅
            this.cardOwners = new List<string>();
            
            // ˄
        }

        public override IProduct CreateProduct(string owner)
        {
            // ˅
            return new CreditCard(owner);
            // ˄
        }

        public override void RegisterProduct(IProduct product)
        {
            // ˅
            cardOwners.Add(((CreditCard)product).Owner);
            // ˄
        }

        public List<string> GetCardOwner()
        {
            // ˅
            return cardOwners;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
