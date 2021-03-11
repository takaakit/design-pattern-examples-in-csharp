// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class LazySupporter : Supporter
    {
        // ˅
        
        // ˄

        public LazySupporter(string name)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            
            // ˄
        }

        // No troubles are handled.
        protected override bool CanHandle(Trouble trouble)
        {
            // ˅
            return false;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
