// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.FactoryMethod.Framework
{
    public abstract class Factory
    {
        // ˅
        
        // ˄

        public IProduct Create(string owner)
        {
            // ˅
            // Write pre-creation code here.

            // Encapsulate the knowledge of which Product subclass to create and move this knowledge out of the framework.
            IProduct product = CreateProduct(owner);

            // Write post-creation code here.

            return product;
            // ˄
        }

        public abstract IProduct CreateProduct(string owner);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
