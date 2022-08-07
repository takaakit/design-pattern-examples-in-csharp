// ˅

// ˄

namespace BehavioralPatterns.Strategy
{
    // Mirror Strategy: showing a hand signal from the previous opponent's hand signal.
    public class MirrorStrategy : IStrategy
    {
        // ˅
        
        // ˄

        private HandSignal preOpponentsHand;

        public MirrorStrategy()
            // ˅
            
            // ˄
        {
            // ˅
            preOpponentsHand = HandSignal.GetHand(HandSignal.ROCK);
            
            // ˄
        }

        public HandSignal ShowHandSignal()
        {
            // ˅
            return preOpponentsHand;
            // ˄
        }

        public void NotifyGameResult(GameResultType result, HandSignal ownHand, HandSignal opponentsHand)
        {
            // ˅
            preOpponentsHand = opponentsHand;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
