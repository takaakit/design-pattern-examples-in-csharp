// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// ˄

namespace StructuralPatterns.Facade
{
    public class HtmlWriter
    {
        // ˅
        
        // ˄

        private readonly StreamWriter writer;

        public HtmlWriter(StreamWriter writer)
            // ˅
            
            // ˄
        {
            // ˅
            this.writer = writer;
            
            // ˄
        }

        // Write a title
        public void Heading(string title)
        {
            // ˅
            writer.Write("<html>");
            writer.Write($"<head><title>{title}</title></head>");
            writer.Write("<body>\n");
            writer.Write($"<h1>{title}</h1>\n");
            // ˄
        }

        // Write a paragraph
        public void Paragraph(string message)
        {
            // ˅
            writer.Write($"<p>{message}</p>\n");
            // ˄
        }

        // Write a link
        public void Anchor(string url, string text)
        {
            // ˅
            Paragraph($"<a href=\"{url}\">{text}</a>");
            // ˄
        }

        // Write a mail address
        public void Mailto(string mailAddress, string userName)
        {
            // ˅
            Anchor($"mailto:{mailAddress}", userName);
            // ˄
        }

        public void Close()
        {
            // ˅
            writer.Write("</body>");
            writer.Write("</html>\n");
            writer.Close();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
