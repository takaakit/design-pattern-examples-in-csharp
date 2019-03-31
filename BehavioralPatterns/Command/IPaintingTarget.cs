// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Command
{
    public interface IPaintingTarget
    {

        void Paint(double x, double y);

        void Clear();

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
