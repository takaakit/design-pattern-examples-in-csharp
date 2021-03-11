// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Composite
{
    public abstract class FileSystemElement
    {
        // ˅
        
        // ˄

        public abstract string Name
        {
            // ˅
            get;
            // ˄
        }

        public abstract int Size
        {
            // ˅
            get;
            // ˄
        }

        // Print this element with the "upperPath".
        public abstract void Print(string upperPath);

        public override string ToString()
        {
            // ˅
            return $"{Name} ({Size})";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
