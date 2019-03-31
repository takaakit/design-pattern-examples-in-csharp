using System;

// Check whether the same instance is obtained.

namespace CreationalPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.GetInstance();
            if (obj1 == obj2)
            {
                Console.WriteLine("obj1 and obj2 are the same instance.");
            }
            else
            {
                Console.WriteLine("obj1 and obj2 are different instances.");
            }
        }
    }
}
