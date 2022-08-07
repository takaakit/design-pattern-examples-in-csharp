// ˅
using System;

// ˄

namespace StructuralPatterns.Decorator
{
    public abstract class Display
    {
        // ˅
        
        // ˄

        // Column width
        public abstract int Columns
        {
            // ˅
            get;
            // ˄
        }

        // Number of rows
        public abstract int Rows
        {
            // ˅
            get;
            // ˄
        }

        public abstract string GetLineText(int row);

        // Show all
        public void Show()
        {
            // ˅
            for (int i = 0; i < Rows; i++)
            {
                Console.WriteLine(GetLineText(i));
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
