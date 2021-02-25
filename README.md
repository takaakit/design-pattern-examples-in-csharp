[<img src="./screenshots/DiagramMap.svg">](https://raw.githubusercontent.com/takaakit/design-pattern-examples-in-csharp/master/screenshots/DiagramMap.svg)

Design Pattern Examples in C#
===

Model and code examples of GoF Design Patterns for C#.  
This project is available for the following objectives:  

* To try Model-Driven Development (MDD) using Astah and M PLUS plug-in.
* To understand the mapping between UML model and C# code.
* To understand GoF Design Pattern examples in C#.  
  etc.

> UML model example:

![](screenshots/CompositePattern.png "Composite Pattern")

> C# file example:
---
```cpp:File class
// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace StructuralPatterns.Composite
{
    public class File : FileSystemElement
    {
        // ˅
        
        // ˄

        protected override string Name
        {
            // ˅
            get; set;
            // ˄
        }

        protected override int Size
        {
            // ˅
            get; set;
            // ˄
        } = 0;

        public File(string name, int size)
            // ˅
            
            // ˄
        {
            // ˅
            this.Name = name;
            this.Size = size;
            // ˄
        }

        // Print this element with the "upperPath".
        public override void Print(string upperPath)
        {
            // ˅
            Console.WriteLine($"{upperPath}/{this}");
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
```

Installation
------------
**Astah**
* Download Astah UML or Professional from [Change Vision site](http://astah.net/download), and install.  

**M PLUS plug-in**
* Download the plug-in from [M PLUS plug-in site](https://sites.google.com/view/m-plus-plugin/download), and install.  
  **Use ver.2.4.0 or higher.**

**Visual Studio IDE**
* Download [Visual Studio IDE](https://visualstudio.microsoft.com/vs/), and install.  

Usage
-----
* Select model elements on the model browser of Astah, and press the "Generate code" button to generate.  
* The generated code has "User Code Area". The "User Code Area" is the area enclosed by "˅" and "˄". Handwritten code written in the "User Code Area" remains after a re-generation.
* You can run the program from "main.cpp" for each Design Pattern.
* For detailed usage of the tools, please see [Astah Manual](http://astah.net/manual) and [M PLUS plug-in Tips](https://sites.google.com/view/m-plus-plugin/tips).

![](screenshots/Usage.gif "Usage")

References
----------
* Gamma, E. et al. Design Patterns: Elements of Reusable Object-Oriented Software, Addison-Wesley, 1994
* Hiroshi Yuki. Learning Design Patterns in Java [In Japanese Language], Softbank publishing, 2004

Licence
-------
This project is licensed under the Creative Commons Zero (CC0) license. The model and code are completely free to use.

[![CC0](http://i.creativecommons.org/p/zero/1.0/88x31.png "CC0")](http://creativecommons.org/publicdomain/zero/1.0/deed)
