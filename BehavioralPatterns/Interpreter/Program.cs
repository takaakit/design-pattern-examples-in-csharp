﻿using System;

/*
An interpreter for mini language to operate radio controlled car. It parses the following syntax
composed of "forward", "left", "right", and "repeat" commands:
```
<program>      ::= program <command list>
<command list> ::= <command>* end
<command>      ::= <repeat> | <action>
<repeat>       ::= repeat <number> <command list>
<action>       ::= forward | right | left
<number>       ::= 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9
```
___
Examples before and after syntax analysis.

Ex.1
```
Before parsing : program end
After parsing  : [program []]
```

Ex.2
```
Before parsing : program forward right left end
After parsing  : [program [forward, right, left]]
```

Ex.3
```
Before parsing : program repeat 4 forward right end end
After parsing  : [program [repeat 4 [forward, right]]]
```
*/

namespace BehavioralPatterns.Interpreter
{
    class Program
    {
        static void Main()
        {
            // Reads commands line by line from the "program.txt" and parses them.
            string projectDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            foreach (string line in System.IO.File.ReadLines($"{projectDirectory}/program.txt", System.Text.Encoding.UTF8))
            {
                Console.WriteLine($"Before parsing : {line}");
                INode node = new Head();
                node.Parse(new Context(line));
                Console.WriteLine($"After parsing  : {node}");
            }
        }
    }
}
