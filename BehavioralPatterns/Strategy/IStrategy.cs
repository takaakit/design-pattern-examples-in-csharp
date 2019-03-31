// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Strategy
{
    public interface IStrategy
    {

        Hand NextHand();

        void Learn(bool win);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
