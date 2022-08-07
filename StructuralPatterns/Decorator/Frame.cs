// ˅

// ˄

namespace StructuralPatterns.Decorator
{
    public abstract class Frame : Display
    {
        // ˅
        
        // ˄

        protected Display display;

        protected Frame(Display display)
            // ˅
            
            // ˄
        {
            // ˅
            this.display = display;
            
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
