using System;

/*
Display a string consisting of large characters (0-9 digits only).
Large character objects are not created until they are needed.
And the created objects are reused.

Example Output
-----
Please enter digits (ex. 1212123): 123
              
     ####     
      ###     
      ###     
      ###     
      ###     
      ###     
    #######   
              

              
   ########   
         ###  
         ###  
   ########   
  #           
  #           
  ##########  
              

              
   ########   
         ###  
         ###  
   ########   
         ###  
  #      ###  
   ########
 */

namespace StructuralPatterns.Flyweight
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter digits (ex. 1212123):");
            string inputValue = Console.ReadLine();

            LargeSizeString lss = new LargeSizeString(inputValue);
            lss.Display();
        }
    }
}
