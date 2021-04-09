// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // Defines an updating interface for objects that should be notified of changes in a subject.
    public interface IObserver
    {

        void Update(Subject changedSubject);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
