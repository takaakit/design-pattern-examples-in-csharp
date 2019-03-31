// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Visitor
{
    public interface IElement
    {

        void Accept(IVisitor visitor);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
