using System;

/*
Analyze the syntax of the mini-language composed of "forward", "left", "right", and "repeat" commands.

-----
Examples before and after syntax analysis.
* Ex.1
Before : "program end"
After  : [program []]

* Ex.2
Before : "program forward right left end"
After  : [program [forward, right, left]]

* Ex.3
Before : "program repeat 4 forward right end end"
After  : [program [repeat 4 [forward, right]]]
*/

namespace BehavioralPatterns.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(System.IO.Path.GetDirectoryName(System.Environment.CommandLine) + "/../../../program.txt", System.Text.Encoding.UTF8))
            {
                var line = "";
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine($"TEXT > \"{line}\"");
                    INode node = new Head();
                    node.Parse(new Context(line));
                    Console.WriteLine($"NODE > {node}");
                }
            }
        }
    }
}
