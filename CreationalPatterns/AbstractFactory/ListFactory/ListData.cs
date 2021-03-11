// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.Factory;

// ˄

namespace CreationalPatterns.AbstractFactory.ListFactory
{
    public class ListData : Data
    {
        // ˅
        
        // ˄

        public ListData(string name)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            
            // ˄
        }

        public override string ToHTML()
        {
            // ˅
            StringBuilder builder = new StringBuilder();
            builder.Append($"<li>{name}<ul>\n");
            foreach (Item item in items)
            {
                builder.Append(item.ToHTML());
            }
            builder.Append("</ul></li>\n");
            return builder.ToString();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
