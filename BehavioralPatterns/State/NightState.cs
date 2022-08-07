// ˅

// ˄

namespace BehavioralPatterns.State
{
    public sealed class NightState : IState
    {
        // ˅
        
        // ˄

        private static readonly NightState instance = new NightState();

        public static NightState GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        private NightState()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        public void SetTime(IContext context, int hour)
        {
            // ˅
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DaytimeState.GetInstance());
            }
            // ˄
        }

        public void Use(IContext context)
        {
            // ˅
            context.CallSecurityGuardsRoom("Emergency: Use a safe at night!");
            // ˄
        }

        public void Alarm(IContext context)
        {
            // ˅
            context.CallSecurityGuardsRoom("Sound an emergency bell at night");
            // ˄
        }

        public void Phone(IContext context)
        {
            // ˅
            context.RecordSecurityLog("Record a night call");
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return "[Night]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
