// ˅
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.BaseFactory
{
    public abstract class Page
    {
        // ˅
        
        // ˄

        protected readonly string title;

        protected readonly string author;

        protected List<Item> contents;

        public Page(string title, string author)
            // ˅
            
            // ˄
        {
            // ˅
            this.title = title;
            this.author = author;
            this.contents = new List<Item>();
            
            // ˄
        }

        public abstract string ToHTML();

        public void Add(Item item)
        {
            // ˅
            contents.Add(item);
            // ˄
        }

        public void Output()
        {
            // ˅
            var fileName = $"{title}.html";
            using (var writer = new StreamWriter(fileName, false))
            {
                writer.Write(this.ToHTML());
            }
            Console.WriteLine($"{fileName} has been created.");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
