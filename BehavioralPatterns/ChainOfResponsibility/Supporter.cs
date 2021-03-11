// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.ChainOfResponsibility
{
    public abstract class Supporter
    {
        // ˅
        
        // ˄

        // Supporter name
        private readonly string name;

        // Next supporter
        private Supporter next;

        public Supporter(string name)
            // ˅
            
            // ˄
        {
            // ˅
            this.name = name;
            this.next = null;
            
            // ˄
        }

        // Trouble support
        // Troubles are sent around.
        public void Support(Trouble trouble)
        {
            // ˅
            if (CanHandle(trouble))
            {
                Supported(trouble);
            }
            else if (next != null)
            {
                next.Support(trouble);
            }
            else
            {
                Unsupported(trouble);
            }
            // ˄
        }

        // Set a next supporter.
        public Supporter SetNext(Supporter next)
        {
            // ˅
            this.next = next;
            return this.next;
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"[{name}]";
            // ˄
        }

        protected abstract bool CanHandle(Trouble trouble);

        // Trouble was supported.
        private void Supported(Trouble trouble)
        {
            // ˅
            Console.WriteLine($"{trouble} was handled by {this}.");
            // ˄
        }

        // Trouble was unsupported.
        private void Unsupported(Trouble trouble)
        {
            // ˅
            Console.WriteLine($"{trouble} was not handled.");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
