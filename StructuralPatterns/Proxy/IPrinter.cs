// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Proxy
{
    public interface IPrinter
    {

        string GetName();

        void ChangeName(string name);

        void Output(string content);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
