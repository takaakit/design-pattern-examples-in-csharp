// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.Prototype.Framework;

// ˄

namespace CreationalPatterns.Prototype
{
    public class UnderlineDisplay : IDisplay
    {
        // ˅
        
        // ˄

        private readonly char underlineChar;

        public UnderlineDisplay(char underlineChar)
            // ˅
            
            // ˄
        {
            // ˅
            this.underlineChar = underlineChar;
            
            // ˄
        }

        public IDisplay CreateClone()
        {
            // ˅
            return new UnderlineDisplay(this.underlineChar);
            // ˄
        }

        public void Show(string message)
        {
            // ˅
            var length = message.Length;
            Console.WriteLine($"\"{message}\"");
            Console.Write(" ");
            for (var i = 0; i < length; i++)
            {
                Console.Write(underlineChar);
            }
            Console.WriteLine("");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
