// ˅
using System;
using System.Collections.Generic;

// ˄

namespace StructuralPatterns.Facade
{
    public sealed class DataLibrary
    {
        // ˅
        
        // ˄

        private static readonly DataLibrary instance = new DataLibrary();

        private DataLibrary()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        public static DataLibrary GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        // Read a data library file.
        public Dictionary<string, string> GetData(string dataLibraryFileName)
        {
            // ˅
            Dictionary<string, string> data = new Dictionary<string, string>();

            foreach (string line in System.IO.File.ReadLines(dataLibraryFileName, System.Text.Encoding.UTF8))
            {
                string[] keyAndValue = line.Split("=");
                if (keyAndValue.Length == 2)
                {
                    data.Add(keyAndValue[0], keyAndValue[1]);
                }
                else
                {
                    throw new FormatException();
                }
            }

            return data;
            // ˄
        }

        // ˅

        // ˄
    }
}

// ˅

// ˄
