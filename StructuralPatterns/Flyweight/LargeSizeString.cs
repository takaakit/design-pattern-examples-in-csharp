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
            this.largeSizeChars = new List<LargeSizeChar>();
            
            foreach (var c in stringValue)
            {
                largeSizeChars.Add(LargeSizeCharFactory.GetInstance().GetLargeSizeChar(c));
            }
            // ˄
        }

        public void Display()
        {
            // ˅
            for (var i = 0; i < largeSizeChars.Count; i++)
            {
                largeSizeChars[i].Display();
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
