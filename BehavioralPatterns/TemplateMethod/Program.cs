/*
Display a character or string repeatedly 5 times.
 */

namespace BehavioralPatterns.TemplateMethod
{
    class Program
    {
        static void Main()
        {
            CharDisplay display1 = new CharDisplay('H');
            display1.Output();

            StringDisplay display2 = new StringDisplay("Hello world.");
            display2.Output();
        }
    }
}
