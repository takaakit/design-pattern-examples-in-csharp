// ˅

// ˄

namespace CreationalPatterns.Singleton
{
    public sealed class Singleton
    {
        // ˅
        
        // ˄

        private static readonly Singleton instance = new Singleton();

        public static Singleton GetInstance()
        {
            // ˅
            return instance;
            // ˄
        }

        private Singleton()
            // ˅
            
            // ˄
        {
            // ˅
            
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
