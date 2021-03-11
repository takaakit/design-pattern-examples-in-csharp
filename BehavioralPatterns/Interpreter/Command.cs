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
            INode aNode;
            if (context.GetToken() == "repeat")
            {
                aNode = new Repeat();
                aNode.Parse(context);
            }
            else
            {
                aNode = new Action();
                aNode.Parse(context);
            }

            this.node = aNode;      // Hold the parsed node
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
