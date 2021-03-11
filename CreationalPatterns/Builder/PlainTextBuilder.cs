// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.Builder
{
    public class PlainTextBuilder : IBuilder
    {
        // ˅

        // ˄

        // String to output
        public string Content
        {
            // ˅
            get
            {
                return builder.ToString();
            }
            // ˄
        }

        private readonly StringBuilder builder;

        public PlainTextBuilder()
            // ˅
            
            // ˄
        {
            // ˅
            builder = new StringBuilder();
            
            // ˄
        }

        // Make a title of plain text
        public void CreateTitle(string title)
        {
            // ˅
            builder.Append("--------------------------------\n");   // Decoration line
            builder.Append($"[{title}]\n");                         // Title
            builder.Append("\n");                                   // Blank line
            // ˄
        }

        // Make a section of plain text
        public void CreateSection(string section)
        {
            // ˅
            builder.Append($"* {section}\n");                       // Section
            builder.Append("\n");                                   // Blank line
            // ˄
        }

        // Make items of plain text
        public void CreateItems(List<string> items)
        {
            // ˅
            foreach (string item in items)
            {
                builder.Append($"  - {item}\n");                    // Items
            }
            builder.Append("\n");                                   // Blank line
            // ˄
        }

        public void Close()
        {
            // ˅
            builder.Append("--------------------------------\n");   // Decoration line
            // ˄
        }

        // ˅

        // ˄
    }
}

// ˅

// ˄
