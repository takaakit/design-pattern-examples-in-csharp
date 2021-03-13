// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.Singleton
{
    public sealed class Singleton
    {
        // ˅
        
        // ˄

        private static readonly Singleton instance = new Singleton();

        public static Singleton GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        private Singleton()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
