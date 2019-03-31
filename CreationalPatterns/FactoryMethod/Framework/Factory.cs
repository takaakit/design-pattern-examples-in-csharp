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
            IProduct product = CreateProduct(owner);
            RegisterProduct(product);
            return product;
            // ˄
        }

        public abstract IProduct CreateProduct(string owner);

        public abstract void RegisterProduct(IProduct product);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
