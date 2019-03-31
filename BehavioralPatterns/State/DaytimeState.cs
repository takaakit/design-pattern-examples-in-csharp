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

        private DaytimeState()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        public static DaytimeState GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        // Set time
        public void SetTime(IContext context, int hour)
        {
            // ˅
            if (hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
            // ˄
        }

        // Use a safe
        public void UseSafe(IContext context)
        {
            // ˅
            context.RecordSecurityLog("Use a safe in the daytime");
            // ˄
        }

        // Sound a emergency bell
        public void SoundBell(IContext context)
        {
            // ˅
            context.CallSecurityGuardsRoom("Sound a emergency bell in the daytime");
            // ˄
        }

        // Make a normal call
        public void Call(IContext context)
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
