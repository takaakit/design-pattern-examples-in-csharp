// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Strategy
{
    public class Hand
    {
        // ˅
        
        // ˄

        // Rock
        public static readonly int ROCK = 0;

        // Scissors
        public static readonly int SCISSORS = 1;

        // Paper
        public static readonly int PAPER = 2;

        // Hands of rock-scissors-paper
        private static readonly Hand[] hands = { new Hand(ROCK), new Hand(SCISSORS), new Hand(PAPER) };

        // Values of rock, scissors and paper.
        public int Value
        {
            // ˅
            get; private set;
            // ˄
        }

        // Characters of the hands
        private static readonly string[] name = { "Rock", "Scissors", "Paper" };

        // Get an instance of the hand
        public static Hand GetHand(int handValue)
        {
            // ˅
            return hands[handValue];
            // ˄
        }

        public Hand(int value)
            // ˅
            
            // ˄
        {
            // ˅
            this.Value = value;
            // ˄
        }

        // Return true if "this" is stronger than "hand".
        public bool IsStrongerThan(Hand hand)
        {
            // ˅
            return JudgeGame(hand) == 1;
            // ˄
        }

        // Return false if "this" is weaker than "hand".
        public bool IsWeakerThan(Hand hand)
        {
            // ˅
            return JudgeGame(hand) == -1;
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return name[Value];
            // ˄
        }

        // The draw is 0. "this" win is 1. "hand" win is -1.
        private int JudgeGame(Hand hand)
        {
            // ˅
            if (this == hand)
            {
                return 0;
            }
            else if ((this.Value + 1) % 3 == hand.Value)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
