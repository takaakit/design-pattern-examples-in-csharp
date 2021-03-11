// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// ˄

namespace CreationalPatterns.Builder
{
    public class HTMLBuilder : IBuilder
    {
        // ˅
        
        // ˄

        // File name to create
        public string FileName
        {
            // ˅
            get; private set;
            // ˄
        } = null;

        private StreamWriter writer;

        public HTMLBuilder()
            // ˅
            
            // ˄
        {
            // ˅
            this.writer = null;
            
            // ˄
        }

        // Make a title of HTML file
        public void CreateTitle(string title)
        {
            // ˅
            FileName = $"{title}.html";           // Set a title as a file name
            writer = new StreamWriter(FileName);
            writer.WriteLine($"<html><head><title>{title}</title></head><body>");   // Write a title
            writer.WriteLine($"<h1>{title}</h1>");
            // ˄
        }

        // Make a section of HTML file
        public void CreateSection(string section)
        {
            // ˅
            writer.WriteLine($"<p>{section}</p>");  // Write a section
            // ˄
        }

        // Make items of HTML file
        public void CreateItems(List<string> items)
        {
            // ˅
            writer.WriteLine("<ul>");       // Write items
            for (var i = 0; i < items.Count; i++)
            {
                writer.WriteLine($"<li>{items[i]}</li>");
            }
            writer.WriteLine("</ul>");
            // ˄
        }

        public void Close()
        {
            // ˅
            writer.WriteLine("</body></html>");
            writer.Close();                 // Close file
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
