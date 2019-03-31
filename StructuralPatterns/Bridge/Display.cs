// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Bridge
{
    public class Display
    {
        // ˅
        
        // ˄

        private readonly IDisplayImpl impl;

        public Display(IDisplayImpl impl)
            // ˅
            
            // ˄
        {
            // ˅
            this.impl = impl;
            
            // ˄
        }

        public void Output()
        {
            // ˅
            Open();
            Write();
            Close();
            // ˄
        }

        protected void Open()
        {
            // ˅
            impl.ImplOpen();
            // ˄
        }

        protected void Write()
        {
            // ˅
            impl.ImplWrite();
            // ˄
        }

        protected void Close()
        {
            // ˅
            impl.ImplClose();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
