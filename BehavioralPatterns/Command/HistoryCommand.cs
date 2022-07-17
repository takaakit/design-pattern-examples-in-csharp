// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Command
{
    // Holder of the past commands
    public class HistoryCommand : ICommand
    {
        // ˅
        
        // ˄

        // A set of past commands
        private readonly Stack<ICommand> pastCommands;

        public HistoryCommand()
            // ˅
            
            // ˄
        {
            // ˅
            this.pastCommands = new Stack<ICommand>();
            
            // ˄
        }

        // Execute all past commands
        public void Execute()
        {
            // ˅
            foreach (ICommand command in pastCommands)
            {
                command.Execute();
            }
            // ˄
        }

        public void Add(ICommand command)
        {
            // ˅
            pastCommands.Push(command);
            // ˄
        }

        // Delete the last command
        public void Undo()
        {
            // ˅
            if (pastCommands.Count != 0)
            {
                pastCommands.Pop();
            }
            // ˄
        }

        // Delete all past commands
        public void Clear()
        {
            // ˅
            pastCommands.Clear();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
