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

        protected abstract string Name
        {
            // ˅
            get; set;
            // ˄
        }

        protected abstract int Size
        {
            // ˅
            get; set;
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
