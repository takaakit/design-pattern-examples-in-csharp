// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Decorator
{
    public class FullFrame : Frame
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
            set
            {

            }
            // ˄
        }

        // Number of rows added the upper and lower decoration lines
        public override int Rows
        {
            // ˅
            get
            {
                return 1 + display.Rows + 1;
            }
            set
            {

            }
            // ˄
        }

        public FullFrame(Display display)
            // ˅
            : base(display)
            // ˄
        {
            // ˅
            
            // ˄
        }

        public override string GetLineText(int row)
        {
            // ˅
            if (row == 0) {
                return $"+{CreateLine('-', display.Columns)}+"; // Upper frame
            }
            else if (row == display.Rows + 1)
            {
                return $"+{CreateLine('-', display.Columns)}+"; // Bottom frame
            }
            else
            {
                return $"|{display.GetLineText(row - 1)}|";     // Other
            }
            // ˄
        }

        private string CreateLine(char ch, int size)
        {
            // ˅
            var builder = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                builder.Append(ch);
            }
            return builder.ToString();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
