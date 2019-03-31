// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Interpreter
{
    // Node in the syntax tree.
    public interface INode
    {

        void Parse(Context context);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
