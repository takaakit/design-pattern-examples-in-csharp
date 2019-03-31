// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.BaseFactory
{
    public abstract class Factory
    {
        // ˅
        
        // ˄

        public abstract Page CreatePage(string title, string author);

        public abstract Link CreateLink(string name, string url);

        public abstract Data CreateData(string name);

        public static Factory GetFactory(string classname)
        {
            // ˅
            Console.WriteLine(classname);
            Console.WriteLine(Type.GetType(classname));
            return Activator.CreateInstance(Type.GetType(classname)) as Factory;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
