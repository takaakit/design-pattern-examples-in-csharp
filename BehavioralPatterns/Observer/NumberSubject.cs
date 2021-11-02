// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // Holds a value and notifies observers when the value is set.
    public class NumberSubject : Subject
    {
        // ˅

        // ˄

        private int _value;

        public int Value
        {
            // ˅
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                NotifyObservers();
            }
            // ˄
        }

        public NumberSubject()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
