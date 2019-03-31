// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Composite
{
    public class File : FileSystemElement
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

        public File(string name, int size)
            // ˅
            
            // ˄
        {
            // ˅
            this.Name = name;
            this.Size = size;
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
