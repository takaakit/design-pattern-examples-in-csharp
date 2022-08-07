// ˅

// ˄

namespace BehavioralPatterns.State
{
    public interface IState
    {

        void SetTime(IContext context, int hour);

        void Use(IContext context);

        void Alarm(IContext context);

        void Phone(IContext context);

        string ToString();

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
