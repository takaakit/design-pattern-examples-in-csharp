// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Strategy
{
    public class Player
    {
        // ˅
        
        // ˄

        private readonly string name;

        private int winCount;

        private int lossCount;

        private int gameCount;

        private readonly IStrategy strategy;

        public Player(string name, IStrategy strategy)
            // ˅
            
            // ˄
        {
            // ˅
            this.name = name;
            this.winCount = 0;
            this.lossCount = 0;
            this.gameCount = 0;
            this.strategy = strategy;
            
            // ˄
        }

        // Calculate a hand from the strategy.
        public Hand NextHand()
        {
            // ˅
            return strategy.NextHand();
            // ˄
        }

        // Won a game.
        public void Won()
        {
            // ˅
            strategy.Learn(true);
            winCount++;
            gameCount++;
            // ˄
        }

        // Lost a game.
        public void Lost()
        {
            // ˅
            strategy.Learn(false);
            lossCount++;
            gameCount++;
            // ˄
        }

        // Drew a game.
        public void Drew()
        {
            // ˅
            gameCount++;
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"{name} [{gameCount} games, {winCount} won, {lossCount} lost, {gameCount - winCount - lossCount} drew]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
