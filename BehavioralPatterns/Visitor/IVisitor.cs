// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Visitor
{
    public interface IVisitor
    {

        void Visit(File file);

        void Visit(Directory directory);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
