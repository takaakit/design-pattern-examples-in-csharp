// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.Factory
{
    public abstract class BaseFactory
    {
        // ˅
        
        // ˄

        public abstract Page CreatePage(string title, string author);

        public abstract Link CreateLink(string name, string url);

        public abstract Data CreateData(string name);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
