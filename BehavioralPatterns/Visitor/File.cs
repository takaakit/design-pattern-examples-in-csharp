// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Visitor
{
    public class File : FileSystemElement
    {
        // ˅
        
        // ˄

        // File name
        public override string Name
        {
            // ˅
            get;
            // ˄
        }

        // File size
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

        public override void Accept(IVisitor visitor)
        {
            // ˅
            visitor.Visit(this);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
