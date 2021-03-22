// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    public class Subject
    {
        // ˅
        
        // ˄

        private readonly List<IObserver> observers;

        public Subject()
            // ˅
            
            // ˄
        {
            // ˅
            observers = new List<IObserver>();
            
            // ˄
        }

        public void Attach(IObserver observer)
        {
            // ˅
            observers.Add(observer);
            // ˄
        }

        public void Detach(IObserver observer)
        {
            // ˅
            observers.Remove(observer);
            // ˄
        }

        public void NotifyObservers()
        {
            // ˅
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
