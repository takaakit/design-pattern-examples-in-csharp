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

        public override string Name
        {
            // ˅
            get;
            // ˄
        }

        public override int Size
        {
            // ˅
            get
            {
                int size = 0;
                foreach (FileSystemElement element in elements)
                {
                    size += element.Size;
                }
                return size;
            }
            // ˄
        }

        private readonly List<FileSystemElement> elements;

        public Directory(string name)
            // ˅
            
            // ˄
        {
            // ˅
            Name = name;
            elements = new List<FileSystemElement>();

            // ˄
        }

        // Print this element with the "upperPath".
        public override void Print(string upperPath)
        {
            // ˅
            Console.WriteLine($"{upperPath}/{this}");
            foreach (FileSystemElement element in elements)
            {
                element.Print($"{upperPath}/{Name}");
            }
            // ˄
        }

        // Add an element
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
