// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.BaseFactory;

// ˄

namespace CreationalPatterns.AbstractFactory.TableFactory
{
    public class TableFactory : Factory
    {
        // ˅
        
        // ˄

        public override Page CreatePage(string title, string author)
        {
            // ˅
            return new TablePage(title, author);
            // ˄
        }

        public override Link CreateLink(string name, string url)
        {
            // ˅
            return new TableLink(name, url);
            // ˄
        }

        public override Data CreateData(string name)
        {
            // ˅
            return new TableData(name);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
