// ˅
using System.Collections.Generic;

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
