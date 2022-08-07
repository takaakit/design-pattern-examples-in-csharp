// ˅
using System;

// ˄

namespace StructuralPatterns.Adapter
{
    public class MessageDisplay
    {
        // ˅
        
        // ˄

        private readonly string message;

        public MessageDisplay(string message)
            // ˅
            
            // ˄
        {
            // ˅
            this.message = message;
            
            // ˄
        }

        public void DisplayWithHyphens()
        {
            // ˅
            Console.WriteLine($"-- {message} --");
            // ˄
        }

        public void DisplayWithBrackets()
        {
            // ˅
            Console.WriteLine($"[[ {message} ]]");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
