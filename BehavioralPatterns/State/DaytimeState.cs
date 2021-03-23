// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.State
{
    public class DaytimeState : IState
    {
        // ˅
        
        // ˄

        private static readonly DaytimeState instance = new DaytimeState();

        public static DaytimeState GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        private DaytimeState()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        public void SetTime(IContext context, int hour)
        {
            // ˅
            if (hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
            // ˄
        }

        public void Use(IContext context)
        {
            // ˅
            context.RecordSecurityLog("Use a safe in the daytime");
            // ˄
        }

        public void Alarm(IContext context)
        {
            // ˅
            context.CallSecurityGuardsRoom("Sound a emergency bell in the daytime");
            // ˄
        }

        public void Phone(IContext context)
        {
            // ˅
            context.CallSecurityGuardsRoom("Make a normal call in the daytime");
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return "[Daytime]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
