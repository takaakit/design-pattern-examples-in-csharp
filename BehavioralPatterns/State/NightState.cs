// ˅
using System;
using System.Collections.Generic;
using System.Text;

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

        // Set time
        public void SetTime(IContext context, int hour)
        {
            // ˅
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DaytimeState.GetInstance());
            }
            // ˄
        }

        // Use a safe
        public void UseSafe(IContext context)
        {
            // ˅
            context.CallSecurityGuardsRoom("Emergency: Use a safe at night!");
            // ˄
        }

        // Sound a emergency bell
        public void SoundBell(IContext context)
        {
            // ˅
            context.CallSecurityGuardsRoom("Sound a emergency bell at night");
            // ˄
        }

        // Make a normal call
        public void Call(IContext context)
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
