using System;

// Visitors visit a file system composed of files and directories, and displays a list of files/directories.

namespace BehavioralPatterns.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a file system...");
            var rootDir = new Directory("root");
            var homeDir = new Directory("home");
            var binDir = new Directory("bin");
            var etcDir = new Directory("etc");
            var emilyDir = new Directory("emily");
            var jamesDir = new Directory("james");
            var oliviaDir = new Directory("olivia");

            rootDir.Add(homeDir);
            rootDir.Add(binDir);
            rootDir.Add(etcDir);

            binDir.Add(new File("ls", 100));
            binDir.Add(new File("mkdir", 50));
            homeDir.Add(emilyDir);
            homeDir.Add(jamesDir);
            homeDir.Add(oliviaDir);

            emilyDir.Add(new File("homework.doc", 40));
            jamesDir.Add(new File("homework.doc", 50));
            jamesDir.Add(new File("app.exe", 60));
            oliviaDir.Add(new File("homework.doc", 70));
            oliviaDir.Add(new File("app.exe", 80));
            oliviaDir.Add(new File("tips.html", 90));

            rootDir.Accept(new ListVisitor());
        }
    }
}
