// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.Prototype.Framework
{
    public class Manager
    {
        // ˅
        
        // ˄

        private readonly Dictionary<string, IDisplay> display;

        public Manager()
            // ˅
            
            // ˄
        {
            // ˅
            display = new Dictionary<string, IDisplay>();
            
            // ˄
        }

        public void RegisterDisplay(string displayName, IDisplay display)
        {
            // ˅
            this.display.Add(displayName, display);
            // ˄
        }

        public IDisplay GetDisplay(string displayName)
        {
            // ˅
            IDisplay d = display[displayName];
            return d.Clone();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
