// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.BaseFactory;

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
            var builder = new StringBuilder();
            builder.Append($"<li>{name}<ul>\n");
            foreach (var item in items)
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
