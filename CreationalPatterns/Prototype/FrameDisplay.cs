// ˅
using CreationalPatterns.Prototype.Framework;
using System;

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

        public IDisplay Clone()
        {
            // ˅
            return new FrameDisplay(borderChar);
            // ˄
        }

        public void Show(string message)
        {
            // ˅
            int length = message.Length;
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(borderChar);
            }
            Console.WriteLine();
            Console.WriteLine($"{borderChar} {message} {borderChar}");
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(borderChar);
            }
            Console.WriteLine();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
