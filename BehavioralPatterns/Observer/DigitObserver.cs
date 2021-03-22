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

        private readonly NumberSubject numberSubject;

        public DigitObserver(NumberSubject numberSubject)
            // ˅
            
            // ˄
        {
            // ˅
            this.numberSubject = numberSubject;
            // ˄
        }

        public void Update(Subject changedSubject)
        {
            // ˅
            if (changedSubject == numberSubject)
            {
                Console.WriteLine($"Digit    : {numberSubject.Value}");
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
