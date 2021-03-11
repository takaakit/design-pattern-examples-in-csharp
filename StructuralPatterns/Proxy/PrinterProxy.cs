// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Proxy
{
    public class PrinterProxy : IPrinter
    {
        // ˅
        
        // ˄

        private string currentName;

        public string PrinterName
        {
            // ˅
            get
            {
                return currentName;
            }
            set
            {
                if (real != null)
                {
                    real.printerName = value;
                }
                currentName = value;
            }
            // ˄
        }

        // A printer that actually prints
        private RealPrinter real;

        public PrinterProxy(string name)
            // ˅
            
            // ˄
        {
            // ˅
            currentName = name;
            real = null;
            
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
