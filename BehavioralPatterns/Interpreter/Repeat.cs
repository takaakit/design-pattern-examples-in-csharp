// ˅

// ˄

namespace BehavioralPatterns.Interpreter
{
    // A node corresponding to "repeat".
    public class Repeat : INode
    {
        // ˅
        
        // ˄

        private int number;

        private INode commandList;

        public Repeat()
            // ˅
            
            // ˄
        {
            // ˅
            this.number = 0;
            this.commandList = null;
            
            // ˄
        }

        public void Parse(Context context)
        {
            // ˅
            context.SlideToken("repeat");

            number = context.GetNumber();
            context.SlideToken(number.ToString());

            CommandList aCommandList = new CommandList();
            aCommandList.Parse(context);

            this.commandList = aCommandList;    // Hold the parsed command list
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"repeat {number} {commandList}";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
