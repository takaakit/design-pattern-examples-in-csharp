// ˅
using System;

// ˄

namespace BehavioralPatterns.Strategy
{
    // Random Strategy: showing a random hand signal.
    public class RandomStrategy : IStrategy
    {
        // ˅
        
        // ˄

        private readonly Random random;

        public RandomStrategy()
            // ˅
            
            // ˄
        {
            // ˅
            this.random = new Random();
            
            // ˄
        }

        public HandSignal ShowHandSignal()
        {
            // ˅
            return HandSignal.GetHand(random.Next(3));
            // ˄
        }

        public void NotifyGameResult(GameResultType result, HandSignal ownHand, HandSignal opponentsHand)
        {
            // ˅
            // Do nothing
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
