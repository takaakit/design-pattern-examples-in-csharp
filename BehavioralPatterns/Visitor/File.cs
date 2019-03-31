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
            get; set;
            // ˄
        }

        public override int Size
        {
            // ˅
            get; set;
            // ˄
        }

        public File(string name, int size)
            // ˅
            
            // ˄
        {
            // ˅
            this.Name = name;
            this.Size = size;
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
