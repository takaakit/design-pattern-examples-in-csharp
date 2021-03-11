// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Visitor
{
    public class Directory : FileSystemElement
    {
        // ˅
        
        // ˄

        // Directory name
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
                foreach (FileSystemElement element in Elements)
                {
                    size += element.Size;
                }
                return size;
            }
            // ˄
        }

        // Collection of elements
        public List<FileSystemElement> Elements
        {
            // ˅
            get; private set;
            // ˄
        } = new List<FileSystemElement>();

        public Directory(string name)
            // ˅
            
            // ˄
        {
            // ˅
            Name = name;
            // ˄
        }

        // Accept a visitor
        public override void Accept(IVisitor visitor)
        {
            // ˅
            visitor.Visit(this);
            // ˄
        }

        // Add an element
        public FileSystemElement Add(FileSystemElement element)
        {
            // ˅
            Elements.Add(element);
            return this;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
