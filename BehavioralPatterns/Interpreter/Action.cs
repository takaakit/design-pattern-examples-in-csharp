// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Interpreter
{
    // A node corresponding to "forward", "left", and "right".
    public class Action : INode
    {
        // ˅
        
        // ˄

        private string name;

        public void Parse(Context context)
        {
            // ˅
            this.name = context.GetToken();
            context.SlideToken(name);
            if (name != "forward" && name != "right" && name != "left")
            {
                throw new System.Exception($"{name} is unknown");
            }
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return name;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
