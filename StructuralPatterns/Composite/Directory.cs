// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Composite
{
    public class Directory : FileSystemElement
    {
        // ˅
        
        // ˄

        protected override string Name
        {
            // ˅
            get; set;
            // ˄
        }

        protected override int Size
        {
            // ˅
            get; set;
            // ˄
        } = 0;

        private readonly List<FileSystemElement> elements;

        public Directory(string name)
            // ˅
            
            // ˄
        {
            // ˅
            this.elements = new List<FileSystemElement>();
            this.Name = name;
            
            // ˄
        }

        // Print this element with the "upperPath".
        public override void Print(string upperPath)
        {
            // ˅
            Console.WriteLine($"{upperPath}/{this}");
            foreach (var element in elements)
            {
                element.Print($"{upperPath}/{Name}");
            }
            // ˄
        }

        // Add a element
        public FileSystemElement Add(FileSystemElement element)
        {
            // ˅
            elements.Add(element);
            return this;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
