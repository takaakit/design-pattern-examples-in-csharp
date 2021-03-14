// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // Generate a random number.
    public class RandomNumber : Number
    {
        // ˅

        // ˄

        private readonly Random random;

        public RandomNumber()
            // ˅
            
            // ˄
        {
            // ˅
            random = new Random();
            
            // ˄
        }

        public override void Generate()
        {
            // ˅
            for (int i = 0; i < 20; i++)
            {
                Value = random.Next(50);
                NotifyObservers();
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
