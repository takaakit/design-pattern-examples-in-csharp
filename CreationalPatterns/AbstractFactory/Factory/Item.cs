// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.Factory
{
    public abstract class Item
    {
        // ˅
        
        // ˄

        protected readonly string name;

        public Item(string name)
            // ˅
            
            // ˄
        {
            // ˅
            this.name = name;
            
            // ˄
        }

        public abstract string ToHTML();

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
