// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Bridge
{
    public class TextDisplayImpl : IDisplayImpl
    {
        // ˅
        
        // ˄

        // A string to display
        private readonly string text;

        // A number of characters in bytes
        private readonly int width;

        public TextDisplayImpl(string text)
            // ˅
            
            // ˄
        {
            // ˅
            this.text = text;
            this.width = text.Length;   // Set the number of characters in bytes.
            
            // ˄
        }

        public void ImplOpen()
        {
            // ˅
            PrintLine();
            // ˄
        }

        public void ImplWrite()
        {
            // ˅
            Console.WriteLine($":{text}:");     // Enclose a text with ":" and display it.
            // ˄
        }

        public void ImplClose()
        {
            // ˅
            PrintLine();
            // ˄
        }

        private void PrintLine()
        {
            // ˅
            Console.Write("*");                 // Display "*" mark at the beginning of a frame.
            for (int i = 0; i < width; i++)     // Display "." for the number of "width".
            {
                Console.Write(".");
            }
            Console.Write("*\n");               // Display "*" mark at the end of a frame.
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
