// ˅
using System;

// ˄

namespace StructuralPatterns.Composite
{
    public class File : FileSystemElement
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
            get;
            // ˄
        }

        public File(string name, int size)
            // ˅
            
            // ˄
        {
            // ˅
            Name = name;
            Size = size;
            // ˄
        }

        // Print this element with the "upperPath".
        public override void Print(string upperPath)
        {
            // ˅
            Console.WriteLine($"{upperPath}/{this}");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
