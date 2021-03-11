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
            displayData = null;
            try
            {
                StreamReader reader = new StreamReader($"{System.IO.Path.GetDirectoryName(System.Environment.CommandLine)}/../../../big{charName}.txt", System.Text.Encoding.UTF8);
                string line = "";
                StringBuilder builder = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    builder.Append(line);
                    builder.Append("\n");
                }
                reader.Close();
                displayData = builder.ToString();
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
