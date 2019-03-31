// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.BaseFactory;

// ˄

namespace CreationalPatterns.AbstractFactory.ListFactory
{
    public class ListLink : Link
    {
        // ˅
        
        // ˄

        public ListLink(string name, string url)
            // ˅
            : base(name, url)
            // ˄
        {
            // ˅
            
            // ˄
        }

        public override string ToHTML()
        {
            // ˅
            return $"  <li><a href=\"{url}\">{name}</a></li>\n";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
