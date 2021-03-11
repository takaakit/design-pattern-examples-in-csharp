// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Flyweight
{
    public class LargeSizeString
    {
        // ˅
        
        // ˄

        private readonly List<LargeSizeChar> largeSizeChars;

        public LargeSizeString(string stringValue)
            // ˅
            
            // ˄
        {
            // ˅
            largeSizeChars = new List<LargeSizeChar>();
            foreach (char c in stringValue)
            {
                largeSizeChars.Add(LargeSizeCharFactory.GetInstance().GetLargeSizeChar(c));
            }
            // ˄
        }

        public void Display()
        {
            // ˅
            foreach (LargeSizeChar largeSizeChar in largeSizeChars)
            {
                largeSizeChar.Display();
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
