// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// ˄

namespace StructuralPatterns.Flyweight
{
    public class LargeSizeChar
    {
        // ˅
        
        // ˄

        // Display data of the large size character
        private readonly string displayData;

        public LargeSizeChar(char charName)
            // ˅
            
            // ˄
        {
            // ˅
            try
            {
                displayData = System.IO.File.ReadAllText($"{System.IO.Path.GetDirectoryName(System.Environment.CommandLine)}/../../../big{charName}.txt", System.Text.Encoding.UTF8);
            }
            catch
            {
                displayData = $"{charName}?";
            }
            // ˄
        }

        // Display the large size character
        public void Display()
        {
            // ˅
            Console.WriteLine(displayData);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
