// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.Builder
{
    public interface IBuilder
    {

        void CreateTitle(string title);

        void CreateSection(string section);

        void CreateItems(List<string> items);

        void Close();

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
