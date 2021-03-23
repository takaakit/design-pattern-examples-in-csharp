// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Proxy
{
    public class ProxyPrinter : IPrinter
    {
        // ˅
        
        // ˄

        private string currentName;

        // A printer that actually prints
        private RealPrinter real;

        public ProxyPrinter(string name)
            // ˅
            
            // ˄
        {
            // ˅
            currentName = name;
            real = null;
            
            // ˄
        }

        public string GetName()
        {
            // ˅
            return currentName;
            // ˄
        }

        public void ChangeName(string name)
        {
            // ˅
            if (real != null)
            {
                real.ChangeName(name);
            }
            currentName = name;
            // ˄
        }

        public void Output(string content)
        {
            // ˅
            if (real == null)
            {
                real = new RealPrinter(currentName);
            }
            real.Output(content);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
