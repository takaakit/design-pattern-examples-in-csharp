// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.State
{
    public interface IContext
    {

        // Set time
        void SetTime(int hour);

        // Change state
        void ChangeState(IState state);

        // Call a security guard room
        void CallSecurityGuardsRoom(string message);

        // Record security log
        void RecordSecurityLog(string message);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
