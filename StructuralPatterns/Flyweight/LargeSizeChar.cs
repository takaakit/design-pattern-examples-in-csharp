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
        private string displayData;

        public LargeSizeChar(char charName)
            // ˅
            
            // ˄
        {
            // ˅
            this.displayData = null;
            
            var fileName = $"{System.IO.Path.GetDirectoryName(System.Environment.CommandLine)}/../../../big{charName}.txt";
            try
            {
                var reader = new StreamReader(fileName, System.Text.Encoding.UTF8);
                var builder = new StringBuilder();
                var line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    builder.Append(line);
                    builder.Append("\n");
                }
                displayData = builder.ToString();
            }
            catch (Exception)
            {
                displayData = $"{charName}?";
            }
            // ˄
        }

        // Display the large size character
        public void Display()
        {
            // ˅
            Console.Write(displayData);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
