// ˅
using System;
using System.Collections.Generic;
using System.Text;
using CreationalPatterns.AbstractFactory.BaseFactory;

// ˄

namespace CreationalPatterns.AbstractFactory.TableFactory
{
    public class TableLink : Link
    {
        // ˅
        
        // ˄

        public TableLink(string name, string url)
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
            return $"  <td><a href=\"{url}\">{name}</a></td>\n";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
