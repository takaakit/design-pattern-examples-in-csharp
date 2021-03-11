// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.Factory
{
    public abstract class Link : Item
    {
        // ˅
        
        // ˄

        protected readonly string url;

        public Link(string name, string url)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            this.url = url;
            
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
