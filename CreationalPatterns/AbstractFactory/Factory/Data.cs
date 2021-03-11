// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.Factory
{
    public abstract class Data : Item
    {
        // ˅
        
        // ˄

        protected List<Item> items;

        public Data(string name)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            items = new List<Item>();
            
            // ˄
        }

        public void Add(Item item)
        {
            // ˅
            items.Add(item);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
