// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Flyweight
{
    public sealed class LargeSizeCharFactory
    {
        // ˅
        
        // ˄

        private readonly Dictionary<string, LargeSizeChar> poolChars;

        private static readonly LargeSizeCharFactory instance = new LargeSizeCharFactory();

        private LargeSizeCharFactory()
            // ˅
            
            // ˄
        {
            // ˅
            poolChars = new Dictionary<string, LargeSizeChar>();
            
            // ˄
        }

        public static LargeSizeCharFactory GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        // Create an instance of the large size character.
        public LargeSizeChar GetLargeSizeChar(char charName)
        {
            // ˅
            LargeSizeChar lsc;
            if (poolChars.ContainsKey(charName.ToString()) == false)
            {
                lsc = new LargeSizeChar(charName);      // Create an instance
                poolChars.Add(charName.ToString(), lsc);
            }
            else
            {
                lsc = poolChars[charName.ToString()];
            }
            return lsc;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
