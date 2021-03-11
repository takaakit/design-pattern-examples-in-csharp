/*
Display a string with decorative frames. The frames can be combined arbitrarily.
 */

namespace StructuralPatterns.Decorator
{
    class Program
    {
        static void Main()
        {
            Display displayA = new MessageDisplay("Nice to meet you.");
            displayA.Show();

            Display displayB = new SideFrame(new MessageDisplay("Nice to meet you."), '!');
            displayB.Show();

            Display displayC = new FullFrame(new SideFrame(new MessageDisplay("Nice to meet you."), '!'));
            displayC.Show();
        }
    }
}
