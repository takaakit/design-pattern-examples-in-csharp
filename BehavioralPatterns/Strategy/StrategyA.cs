// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Strategy
{
    // When winning a game, show the same hand at the next time.
    public class StrategyA : IStrategy
    {
        // ˅
        
        // ˄

        private readonly Random random;

        private bool won;

        private Hand preHand;

        public StrategyA(int randomSeed)
            // ˅
            
            // ˄
        {
            // ˅
            this.random = new Random(randomSeed);
            this.won = false;
            this.preHand = Hand.GetHand(Hand.ROCK);
            
            // ˄
        }

        public Hand NextHand()
        {
            // ˅
            if (won == false)
            {
                preHand = Hand.GetHand(random.Next(3));
            }
            return preHand;
            // ˄
        }

        public void Learn(bool win)
        {
            // ˅
            won = win;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
