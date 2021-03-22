// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.Prototype.Framework
{
    public interface IDisplay
    {

        IDisplay Clone();

        void Show(string message);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
