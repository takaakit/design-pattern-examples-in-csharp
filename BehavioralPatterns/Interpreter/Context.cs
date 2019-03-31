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

        private string[] nodes;

        private int currentNumber;

        public Context(string text)
            // ˅
            
            // ˄
        {
            // ˅
            this.nodes = text.Split(null);
            this.currentNumber = 0;
            
            // ˄
        }

        public string NextToken()
        {
            // ˅
            if (currentNumber < nodes.Length)
            {
                return nodes[currentNumber++];
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
            return nodes[currentNumber];
            // ˄
        }

        public void SlideToken(string token)
        {
            // ˅
            if (token != nodes[currentNumber])
            {
                throw new System.ArgumentException($"WARNING: {token} is expected but {nodes[currentNumber]} was found.");
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
