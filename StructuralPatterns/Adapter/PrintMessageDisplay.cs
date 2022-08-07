// ˅

// ˄

namespace StructuralPatterns.Adapter
{
    // Adapt the MessageDisplay interface to the Print interface.
    public class PrintMessageDisplay : MessageDisplay, IPrint
    {
        // ˅
        
        // ˄

        public PrintMessageDisplay(string message)
            // ˅
            : base(message)
            // ˄
        {
            // ˅
            
            // ˄
        }

        public void PrintWeak()
        {
            // ˅
            DisplayWithHyphens();
            // ˄
        }

        public void PrintStrong()
        {
            // ˅
            DisplayWithBrackets();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
