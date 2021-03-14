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
        } = 0;

        private readonly List<IObserver> observers;

        public Number()
            // ˅
            
            // ˄
        {
            // ˅
            observers = new List<IObserver>();
            
            // ˄
        }

        public abstract void Generate();

        public void AddObserver(IObserver observer)
        {
            // ˅
            observers.Add(observer);
            // ˄
        }

        public void RemoveObserver(IObserver observer)
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
