// ˅

// ˄

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class SpecialSupporter : Supporter
    {
        // ˅
        
        // ˄

        private readonly int targetId;

        public SpecialSupporter(string name, int targetId)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            this.targetId = targetId;
            
            // ˄
        }

        // Troubles with the specific ID are handled.
        protected override bool CanHandle(Trouble trouble)
        {
            // ˅
            return trouble.id == targetId;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
