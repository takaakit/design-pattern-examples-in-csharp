// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Interpreter
{
    public class Command : INode
    {
        // ˅
        
        // ˄

        private INode node;

        public Command()
            // ˅
            
            // ˄
        {
            // ˅
            this.node = null;
            
            // ˄
        }

        public void Parse(Context context)
        {
            // ˅
            if (context.GetToken() == "repeat")
            {
                node = new Repeat();
                node.Parse(context);
            }
            else
            {
                node = new Action();
                node.Parse(context);
            }
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return node.ToString();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
