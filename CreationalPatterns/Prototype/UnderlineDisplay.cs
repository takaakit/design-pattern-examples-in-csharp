// ˅
using CreationalPatterns.Prototype.Framework;
using System;

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

        public IDisplay Clone()
        {
            // ˅
            return new UnderlineDisplay(underlineChar);
            // ˄
        }

        public void Show(string message)
        {
            // ˅
            int length = message.Length;
            Console.WriteLine($"\"{message}\"");
            Console.Write(" ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(underlineChar);
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
