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

        public Action()
            // ˅
            
            // ˄
        {
            // ˅
            this.name = null;
            // ˄
        }

        public void Parse(Context context)
        {
            // ˅
            string currentToken = context.GetToken();
            if (currentToken != "forward" && currentToken != "right" && currentToken != "left")
            {
                throw new System.Exception($"{currentToken} is unknown");
            }

            this.name = currentToken;   // Hold the current token as this action name

            context.SlideToken(currentToken);
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
