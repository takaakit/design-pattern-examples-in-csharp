// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Interpreter
{
    // A node corresponding to "program".
    public class Head : INode
    {
        // ˅
        
        // ˄

        private INode commandList;

        public Head()
            // ˅
            
            // ˄
        {
            // ˅
            this.commandList = null;
            
            // ˄
        }

        public void Parse(Context context)
        {
            // ˅
            context.SlideToken("program");

            CommandList aCommandList = new CommandList();
            aCommandList.Parse(context);

            this.commandList = aCommandList;    // Hold the parsed command list
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"[program {commandList}]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
