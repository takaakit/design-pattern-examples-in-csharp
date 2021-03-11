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

        // Show a hand signal from the strategy.
        public HandSignal ShowHandSignal()
        {
            // ˅
            return strategy.ShowHandSignal();
            // ˄
        }

        // Notify a game result.
        public void NotifyGameResult(GameResultType result, HandSignal ownHand, HandSignal opponentsHand)
        {
            // ˅
            switch (result)
            {
                case GameResultType.Win:
                    winCount++;
                    gameCount++;
                    break;
                case GameResultType.Loss:
                    lossCount++;
                    gameCount++;
                    break;
                case GameResultType.Draw:
                    gameCount++;
                    break;
            }

            strategy.NotifyGameResult(result, ownHand, opponentsHand);
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
