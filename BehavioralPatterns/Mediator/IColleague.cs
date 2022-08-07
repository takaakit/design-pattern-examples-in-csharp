// ˅

// ˄

namespace BehavioralPatterns.Mediator
{
    public interface IColleague
    {

        IMediator Mediator
        {
            // ˅
            get; set;
            // ˄
        }

        // Set enable/disable from the Mediator
        void SetActivation(bool isEnable);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
