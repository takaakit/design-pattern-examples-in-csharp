// ˅
using System.Collections.Generic;

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
            return d.Clone();       // Create a new object by asking a concrete class to clone itself. Therefore, do not need to know the concrete Display class name.
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
