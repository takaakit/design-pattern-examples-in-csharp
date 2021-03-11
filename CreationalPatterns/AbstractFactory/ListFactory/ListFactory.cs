// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.Factory;

// ˄

namespace CreationalPatterns.AbstractFactory.ListFactory
{
    public class ListFactory : BaseFactory
    {
        // ˅
        
        // ˄

        public override Page CreatePage(string title, string author)
        {
            // ˅
            return new ListPage(title, author);
            // ˄
        }

        public override Link CreateLink(string name, string url)
        {
            // ˅
            return new ListLink(name, url);
            // ˄
        }

        public override Data CreateData(string name)
        {
            // ˅
            return new ListData(name);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
