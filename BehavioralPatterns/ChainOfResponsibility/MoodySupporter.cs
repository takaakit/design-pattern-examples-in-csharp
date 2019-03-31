// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class MoodySupporter : Supporter
    {
        // ˅
        
        // ˄

        public MoodySupporter(string name)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            
            // ˄
        }

        // Troubles with an odd ID are handled.
        protected override bool Handle(Trouble trouble)
        {
            // ˅
            return trouble.id % 2 == 1;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
