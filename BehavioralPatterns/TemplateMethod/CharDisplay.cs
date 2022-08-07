// ˅
using System;

// ˄

namespace BehavioralPatterns.TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        // ˅
        
        // ˄

        private readonly char charValue;

        public CharDisplay(char charValue)
            // ˅
            
            // ˄
        {
            // ˅
            this.charValue = charValue;
            
            // ˄
        }

        public override void Open()
        {
            // ˅
            Console.Write("<<");        // Display "<<" in the start characters.
            // ˄
        }

        public override void Write()
        {
            // ˅
            Console.Write(charValue);   // Display the character.
            // ˄
        }

        public override void Close()
        {
            // ˅
            Console.WriteLine(">>");    // Display ">>" in the end characters.
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
