// ˅
using System.Collections.Generic;

// ˄

namespace BehavioralPatterns.Interpreter
{
    public class CommandList : INode
    {
        // ˅
        
        // ˄

        private readonly List<INode> nodes;

        public CommandList()
            // ˅
            
            // ˄
        {
            // ˅
            this.nodes = new List<INode>();
            
            // ˄
        }

        public void Parse(Context context)
        {
            // ˅
            while (true)
            {
                if (context.GetToken() == null)
                {
                    throw new System.Exception("Missing \"end\"");
                }
                else if (context.GetToken() == "end")
                {
                    context.SlideToken("end");
                    break;
                }
                else
                {
                    INode aNode = new Command();
                    aNode.Parse(context);

                    nodes.Add(aNode);   // Hold the parsed node
                }
            }
            // ˄
        }

        public override string ToString()
        {
            // ˅
            return $"[{string.Join(", ", nodes)}]";
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
