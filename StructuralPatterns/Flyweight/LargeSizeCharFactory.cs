// ˅
using System.Collections.Generic;

// ˄

namespace StructuralPatterns.Flyweight
{
    public sealed class LargeSizeCharFactory
    {
        // ˅
        
        // ˄

        private readonly Dictionary<char, LargeSizeChar> poolChars;

        private static readonly LargeSizeCharFactory instance = new LargeSizeCharFactory();

        private LargeSizeCharFactory()
            // ˅
            
            // ˄
        {
            // ˅
            poolChars = new Dictionary<char, LargeSizeChar>();
            
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
            if (poolChars.ContainsKey(charName) == false)
            {
                lsc = new LargeSizeChar(charName);      // Create an instance
                poolChars.Add(charName, lsc);
            }
            else
            {
                lsc = poolChars[charName];
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
