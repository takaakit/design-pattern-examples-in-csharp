// ˅

// ˄

namespace BehavioralPatterns.Interpreter
{
    // Hold data which will be interpreted.
    public class Context
    {
        // ˅
        
        // ˄

        private readonly string[] tokens;

        private int currentIndex;

        public Context(string text)
            // ˅
            
            // ˄
        {
            // ˅
            this.tokens = text.Split(null);
            this.currentIndex = 0;
            
            // ˄
        }

        public string NextToken()
        {
            // ˅
            if (currentIndex < tokens.Length)
            {
                return tokens[currentIndex++];
            }
            else
            {
                return null;
            }
            // ˄
        }

        public string GetToken()
        {
            // ˅
            return tokens[currentIndex];
            // ˄
        }

        public void SlideToken(string token)
        {
            // ˅
            if (token != GetToken())
            {
                throw new System.ArgumentException($"WARNING: {token} is expected but {GetToken()} was found.");
            }
            NextToken();
            // ˄
        }

        public int GetNumber()
        {
            // ˅
            if (int.TryParse(GetToken(), out int number))
            {
                return number;
            }
            else
            {
                throw new System.ArgumentException($"WARNING: {number}");
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
