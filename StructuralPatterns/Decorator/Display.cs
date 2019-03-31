// ˅
using System;
using System.Collections.Generic;
using System.Text;

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
            get; set;
            // ˄
        }

        // Number of rows
        public abstract int Rows
        {
            // ˅
            get; set;
            // ˄
        }

        public abstract string GetLineText(int row);

        // Show all
        public void Show()
        {
            // ˅
            for (var i = 0; i < Rows; i++)
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
