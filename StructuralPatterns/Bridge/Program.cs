// Display only one line or display the specified number of lines.

namespace StructuralPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new TextDisplayImpl("Japan"));
            MultiLineDisplay d2 = new MultiLineDisplay(new TextDisplayImpl("The United States of America"));
            MultiLineDisplay d3 = new MultiLineDisplay(new TextDisplayImpl("Brazil"));
            d1.Output();
            d2.Output();
            d3.Output();
            d3.OutputMultiple(3);
        }
    }
}
