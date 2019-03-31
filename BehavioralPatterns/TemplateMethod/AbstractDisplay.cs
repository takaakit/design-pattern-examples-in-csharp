// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.TemplateMethod
{
    public abstract class AbstractDisplay
    {
        // ˅
        
        // ˄

        public abstract void Open();

        public abstract void Write();

        public abstract void Close();

        public void Output()
        {
            // ˅
            Open();
            for (var i = 0; i < 5; i++)     // Repeat write 5 times
            {
                Write();
            }
            Close();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
