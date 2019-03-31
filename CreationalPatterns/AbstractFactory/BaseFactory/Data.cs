// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.BaseFactory
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
            this.items = new List<Item>();
            
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
