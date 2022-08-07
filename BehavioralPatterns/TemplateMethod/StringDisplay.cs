// ˅
using System;

// ˄

namespace BehavioralPatterns.TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        // ˅
        
        // ˄

        private readonly string stringValue;

        // String width
        private readonly int width;

        public StringDisplay(string stringValue)
            // ˅
            
            // ˄
        {
            // ˅
            this.stringValue = stringValue;
            this.width = stringValue.Length;
            
            // ˄
        }

        public override void Open()
        {
            // ˅
            WriteLine();                            // Write a line
            // ˄
        }

        public override void Write()
        {
            // ˅
            Console.WriteLine($"|{stringValue}|");  // Display the character with "|"
            // ˄
        }

        public override void Close()
        {
            // ˅
            WriteLine();                            // Write a line
            // ˄
        }

        private void WriteLine()
        {
            // ˅
            Console.Write("+");         // Display an end mark "+"
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");     // Display a line "-"
            }
            Console.WriteLine("+");     // Display an end mark "+"
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
