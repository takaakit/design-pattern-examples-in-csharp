// ˅
using System;

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
                string projectDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                displayData = System.IO.File.ReadAllText($"{projectDirectory}/big{charName}.txt", System.Text.Encoding.UTF8);
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
