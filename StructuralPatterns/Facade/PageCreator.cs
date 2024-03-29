// ˅
using System;
using System.Collections.Generic;
using System.IO;

// ˄

namespace StructuralPatterns.Facade
{
    public sealed class PageCreator
    {
        // ˅
        
        // ˄

        private static readonly PageCreator instance = new PageCreator();

        private PageCreator()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        public static PageCreator GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        public void CreateSimpleHomepage(string mailAddress, string htmlFileName)
        {
            // ˅
            string projectDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            Dictionary<string, string> addressBook = DataLibrary.GetInstance().GetData($"{projectDirectory}/addressbook.txt");
            string userName = addressBook[mailAddress];
            HtmlWriter writer = new HtmlWriter(new StreamWriter(htmlFileName));
            writer.Heading($"{userName}'s homepage");
            writer.Paragraph($"Welcome to {userName}'s homepage.");
            writer.Paragraph("Please email me at this address.");
            writer.Mailto(mailAddress, userName);
            writer.Close();
            Console.WriteLine($"{htmlFileName} is created for {mailAddress} ({userName})");
            Console.WriteLine($"Output File: {Path.Combine(System.Environment.CurrentDirectory, htmlFileName)}");
            // ˄
        }

        // ˅

        // ˄
    }
}

// ˅

// ˄
