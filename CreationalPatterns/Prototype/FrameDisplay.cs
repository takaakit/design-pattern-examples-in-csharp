// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.Prototype.Framework;

// ˄

namespace CreationalPatterns.Prototype
{
    public class FrameDisplay : IDisplay
    {
        // ˅
        
        // ˄

        private readonly char borderChar;

        public FrameDisplay(char borderChar)
            // ˅
            
            // ˄
        {
            // ˅
            this.borderChar = borderChar;
            
            // ˄
        }

        public IDisplay CreateClone()
        {
            // ˅
            return new FrameDisplay(this.borderChar);
            // ˄
        }

        public void Show(string message)
        {
            // ˅
            var length = message.Length;
            for (var i = 0; i < length + 4; i++)
            {
                Console.Write(borderChar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{borderChar} {message} {borderChar}");
            for (var i = 0; i < length + 4; i++)
            {
                Console.Write(borderChar);
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
