// ˅

// ˄

namespace BehavioralPatterns.Strategy
{
    public interface IStrategy
    {

        // Show a hand signal.
        HandSignal ShowHandSignal();

        // Notify a game result.
        void NotifyGameResult(GameResultType result, HandSignal ownHand, HandSignal opponentsHand);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
