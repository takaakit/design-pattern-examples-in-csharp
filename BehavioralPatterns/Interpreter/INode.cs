// ˅

// ˄

namespace BehavioralPatterns.Interpreter
{
    // Node in the syntax tree.
    public interface INode
    {

        void Parse(Context context);

        string ToString();

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
