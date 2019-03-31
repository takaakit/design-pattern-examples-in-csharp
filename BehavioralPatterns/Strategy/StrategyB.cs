// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Strategy
{
    // Calculate a hand from the previous hand stochastically.
    public class StrategyB : IStrategy
    {
        // ˅
        
        // ˄

        private readonly Random random;

        private readonly int[][] history;

        private Hand preHand;

        private Hand curHand;

        public StrategyB(int randomSeed)
            // ˅
            
            // ˄
        {
            // ˅
            this.random = new Random(randomSeed);
            this.history = new int[][]{ new int[]{ 1, 1, 1 }, new int[]{ 1, 1, 1 }, new int[]{ 1, 1, 1 } };
            this.preHand = new Hand(Hand.ROCK);
            this.curHand = new Hand(Hand.ROCK);
            
            // ˄
        }

        public Hand NextHand()
        {
            // ˅
            var randomHandValue = random.Next(GetHistorySum(curHand.Value));
            var handValue = 0;
            if (randomHandValue < history[curHand.Value][0])
            {
                handValue = Hand.ROCK;
            }
            else if (randomHandValue < history[curHand.Value][0] + history[curHand.Value][1])
            {
                handValue = Hand.SCISSORS;
            }
            else
            {
                handValue = Hand.PAPER;
            }
            preHand = curHand;
            curHand = Hand.GetHand(handValue);
            return curHand;
            // ˄
        }

        public void Learn(bool win)
        {
            // ˅
            if (win == true)
            {
                history[preHand.Value][curHand.Value]++;
            }
            else
            {
                history[preHand.Value][(curHand.Value + 1) % 3]++;
                history[preHand.Value][(curHand.Value + 2) % 3]++;
            }
            // ˄
        }

        private int GetHistorySum(int handValue)
        {
            // ˅
            var sum = 0;
            for (var i = 0; i < 3; i++)
            {
                sum += history[handValue][i];
            }
            return sum;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
