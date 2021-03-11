// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.Factory;

// ˄

namespace CreationalPatterns.AbstractFactory.TableFactory
{
    public class TablePage : Page
    {
        // ˅
        
        // ˄

        public TablePage(string title, string author)
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
            builder.Append($"<html><head><title>{title}</title></head><body>\n");
            builder.Append($"<h1>{title}</h1>\n");
            builder.Append("<table width=\"80%\" border=\"3\">\n");
            foreach (Item content in contents)
            {
                builder.Append($"<tr>{content.ToHTML()}</tr>\n");
            }
            builder.Append("</table>\n");
            builder.Append($"<hr><address>{author}</address>\n");
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
