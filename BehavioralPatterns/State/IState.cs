// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.State
{
    public interface IState
    {

        // Set time
        void SetTime(IContext context, int hour);

        // Use a safe
        void UseSafe(IContext context);

        // Sound a emergency bell
        void SoundBell(IContext context);

        // Make a normal call
        void Call(IContext context);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
