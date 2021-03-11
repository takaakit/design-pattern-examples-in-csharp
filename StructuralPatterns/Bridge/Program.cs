/*
Display only one line or display the specified number of lines.
 */

namespace StructuralPatterns.Bridge
{
    class Program
    {
        static void Main()
        {
            Display d1 = new Display(new TextDisplayImpl("Japan"));
            d1.Output();

            MultiLineDisplay d2 = new MultiLineDisplay(new TextDisplayImpl("The United States of America"));
            d2.Output();
            d2.OutputMultiple(3);
        }
    }
}
