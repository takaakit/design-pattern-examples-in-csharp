// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class LimitedSupporter : Supporter
    {
        // ˅
        
        // ˄

        private readonly int limitId;

        public LimitedSupporter(string name, int limitId)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            this.limitId = limitId;
            
            // ˄
        }

        // Troubles with an ID below the limit are handled.
        protected override bool CanHandle(Trouble trouble)
        {
            // ˅
            return trouble.id <= limitId;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
