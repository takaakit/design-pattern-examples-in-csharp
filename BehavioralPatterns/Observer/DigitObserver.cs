// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // Display values as a number.
    public class DigitObserver : IObserver
    {
        // ˅
        
        // ˄

        public void Update(Number number)
        {
            // ˅
            Console.WriteLine($"Digit    : {number.Value}");
            System.Threading.Thread.Sleep(100);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
