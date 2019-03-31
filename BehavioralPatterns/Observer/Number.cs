// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // An abstract class that generates numbers.
    public abstract class Number
    {
        // ˅
        
        // ˄

        public int Value
        {
            // ˅
            get; protected set;
            // ˄
        }

        private readonly List<IObserver> observers;

        public Number()
            // ˅
            
            // ˄
        {
            // ˅
            this.observers = new List<IObserver>();
            
            // ˄
        }

        public abstract void Generate();

        public void AddObserver(IObserver observer)
        {
            // ˅
            observers.Add(observer);
            // ˄
        }

        public void DeleteObserver(IObserver observer)
        {
            // ˅
            observers.Add(observer);
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
