// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Interpreter
{
    // Analyze the syntax
    public class Context
    {
        // ˅
        
        // ˄

        private readonly string[] tokens;

        private int currentTokenIndex;

        public Context(string text)
            // ˅
            
            // ˄
        {
            // ˅
            this.tokens = text.Split(null);
            this.currentTokenIndex = 0;
            
            // ˄
        }

        public string NextToken()
        {
            // ˅
            if (currentTokenIndex < tokens.Length)
            {
                return tokens[currentTokenIndex++];
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
            return tokens[currentTokenIndex];
            // ˄
        }

        public void SlideToken(string token)
        {
            // ˅
            if (token != tokens[currentTokenIndex])
            {
                throw new System.ArgumentException($"WARNING: {token} is expected but {tokens[currentTokenIndex]} was found.");
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
