// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
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
