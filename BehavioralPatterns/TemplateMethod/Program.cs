// Display the character and string repeatedly 5 times.

namespace BehavioralPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay display1 = new CharDisplay('H');                    // Create an instance of the CharDisplay
            AbstractDisplay display2 = new StringDisplay("Hello world.");       // Create an instance of the StringDisplay
            AbstractDisplay display3 = new StringDisplay("Nice to meet you.");  // Create an instance of the StringDisplay

            // Any instance can be called with the same method name
            display1.Output();
            display2.Output();
            display3.Output();
        }
    }
}
