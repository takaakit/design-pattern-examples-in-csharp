using System;

/*
Represents a file system composed of files and directories. FileSystemElement makes
it possible to treat File and Directory uniformly.
 */

namespace StructuralPatterns.Composite
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Create a file system...");

            Directory binDir = new Directory("bin");
            File lsFile = new File("ls", 20);
            binDir.Add(lsFile);
            File mkdirFile = new File("mkdir", 40);
            binDir.Add(mkdirFile);

            Directory emilyDir = new Directory("emily");
            File homeworkFile = new File("homework.doc", 60);
            emilyDir.Add(homeworkFile);

            Directory jamesDir = new Directory("james");
            File appFile = new File("app.exe", 80);
            jamesDir.Add(appFile);

            Directory homeDir = new Directory("home");
            homeDir.Add(emilyDir);
            homeDir.Add(jamesDir);

            Directory rootDir = new Directory("root");
            rootDir.Add(homeDir);
            rootDir.Add(binDir);

            rootDir.Print("");
        }
    }
}
