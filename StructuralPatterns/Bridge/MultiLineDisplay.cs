// ˅

// ˄

namespace StructuralPatterns.Bridge
{
    public class MultiLineDisplay : Display
    {
        // ˅
        
        // ˄

        public MultiLineDisplay(IDisplayImpl impl)
            // ˅
            : base(impl)
            // ˄
        {
            // ˅
            
            // ˄
        }

        // Repeat display for the specified number of times
        public void OutputMultiple(int times)
        {
            // ˅
            Open();
            for (int i = 0; i < times; i++)
            {
                Write();
            }
            Close();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
