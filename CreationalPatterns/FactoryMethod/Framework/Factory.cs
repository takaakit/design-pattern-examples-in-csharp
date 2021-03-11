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
            return CreateProduct(owner);
            // ˄
        }

        public abstract IProduct CreateProduct(string owner);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
