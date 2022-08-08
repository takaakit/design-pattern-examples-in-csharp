using System;

/*
Check whether the same instance is obtained.
 */

namespace CreationalPatterns.Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton obj1 = Singleton.GetInstance();
            Singleton obj2 = Singleton.GetInstance();
            if (obj1.Equals(obj2))
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
