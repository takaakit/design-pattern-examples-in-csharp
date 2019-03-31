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
            this.random = new Random();
            Value = 0;
            
            // ˄
        }

        public override void Generate()
        {
            // ˅
            for (var i = 0; i < 20; i++)
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
