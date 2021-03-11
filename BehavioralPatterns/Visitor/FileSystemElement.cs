// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Visitor
{
    public abstract class FileSystemElement : IElement
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

        public abstract void Accept(IVisitor visitor);

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
