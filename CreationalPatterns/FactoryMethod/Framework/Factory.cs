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
            // Write pre-creation code here, if any.

            IProduct product = CreateProduct(owner);

            // Write post-creation code here, if any.

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
