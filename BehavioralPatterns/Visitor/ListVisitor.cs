// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Visitor
{
    public class ListVisitor : IVisitor
    {
        // ˅
        
        // ˄

        // Currently visited directory
        private string currentDirectory;

        public ListVisitor()
            // ˅
            
            // ˄
        {
            // ˅
            currentDirectory = "";
            
            // ˄
        }

        // Visit a file
        public void Visit(File file)
        {
            // ˅
            Console.WriteLine($"{currentDirectory}/{file}");
            // ˄
        }

        // Visit a directory
        public void Visit(Directory directory)
        {
            // ˅
            Console.WriteLine($"{currentDirectory}/{directory}");
            string visitedDirectory = currentDirectory;
            currentDirectory = $"{currentDirectory}/{directory.Name}";
            foreach (IElement element in directory.Elements)
            {
                element.Accept(this);
            }
            currentDirectory = visitedDirectory;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
