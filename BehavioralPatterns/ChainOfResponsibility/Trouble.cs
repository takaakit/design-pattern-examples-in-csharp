// ˅

// ˄

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class Trouble
    {
        // ˅
        
        // ˄

        // Trouble number
        public readonly int id;

        public Trouble(int id)
            // ˅
            
            // ˄
        {
            // ˅
            this.id = id;
            
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"[Trouble {id}]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
