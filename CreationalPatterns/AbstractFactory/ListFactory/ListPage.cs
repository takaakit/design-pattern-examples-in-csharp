// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.Factory;

// ˄

namespace CreationalPatterns.AbstractFactory.ListFactory
{
    public class ListPage : Page
    {
        // ˅
        
        // ˄

        public ListPage(string title, string author)
            // ˅
            : base(title, author)
            // ˄
        {
            // ˅
            
            // ˄
        }

        public override string ToHTML()
        {
            // ˅
            StringBuilder builder = new StringBuilder();
            builder.Append($"<html><head><title>{title}</title></head>\n");
            builder.Append($"<body><h1>{title}</h1>\n");
            builder.Append("<ul>\n");
            foreach (Item content in contents)
            {
                builder.Append(content.ToHTML());
            }
            builder.Append("</ul>\n");
            builder.Append($"<hr><address>{author}</address>");
            builder.Append("</body></html>\n");
            return builder.ToString();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
