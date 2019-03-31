// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace CreationalPatterns.Builder
{
    public class Director
    {
        // ˅
        
        // ˄

        private readonly IBuilder builder;

        public Director(IBuilder builder)
            // ˅
            
            // ˄
        {
            // ˅
            this.builder = builder;
            
            // ˄
        }

        // Construct a document
        public void Build()
        {
            // ˅
            builder.CreateTitle("Greeting");                                                        // Title
            builder.CreateSection("Morning and Afternoon");                                         // Section
            builder.CreateItems(new List<string>{ "Good morning.", "Hello." });                     // Items
            builder.CreateSection("Evening");                                                       // Other section
            builder.CreateItems(new List<string> { "Good evening.", "Good night.", "Goodbye." });   // Other items
            builder.Close();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
