// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // Display values with digits.
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
