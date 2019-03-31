// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Interpreter
{
    // A node corresponding to "repeat".
    public class Repeat : INode
    {
        // ˅
        
        // ˄

        private int number;

        private INode commandList;

        public Repeat()
            // ˅
            
            // ˄
        {
            // ˅
            this.number = 0;
            this.commandList = null;
            
            // ˄
        }

        public void Parse(Context context)
        {
            // ˅
            context.SlideToken("repeat");
            number = context.GetNumber();
            context.NextToken();
            commandList = new CommandList();
            commandList.Parse(context);
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"[repeat {number} {commandList}]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
