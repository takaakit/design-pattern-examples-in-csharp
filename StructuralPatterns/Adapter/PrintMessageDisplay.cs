// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Adapter
{
    public class PrintMessageDisplay : MessageDisplay, IPrint
    {
        // ˅
        
        // ˄

        public PrintMessageDisplay(string message)
            // ˅
            : base(message)
            // ˄
        {
            // ˅
            
            // ˄
        }

        public void PrintWeak()
        {
            // ˅
            DisplayWithHyphens();
            // ˄
        }

        public void PrintStrong()
        {
            // ˅
            DisplayWithBrackets();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
