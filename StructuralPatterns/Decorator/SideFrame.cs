// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Decorator
{
    public class SideFrame : Frame
    {
        // ˅
        
        // ˄

        // Number of characters added left and right decoration characters
        public override int Columns
        {
            // ˅
            get
            {
                return 1 + display.Columns + 1;
            }
            // ˄
        }

        // Number of lines
        public override int Rows
        {
            // ˅
            get
            {
                return display.Rows;
            }
            // ˄
        }

        // Decoration character
        private readonly char frameChar;

        public SideFrame(Display display, char frameChar)
            // ˅
            : base(display)
            // ˄
        {
            // ˅
            this.frameChar = frameChar;
            
            // ˄
        }

        public override string GetLineText(int row)
        {
            // ˅
            return frameChar.ToString() + display.GetLineText(row) + frameChar.ToString();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
