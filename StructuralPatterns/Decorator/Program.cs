// Display a character string with a decorative frame.

namespace StructuralPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Display displayA = new MessageDisplay("Nice to meet you.");
            displayA.Show();

            Display displayB = new SideFrame(displayA, '!');
            displayB.Show();

            Display displayC = new FullFrame(displayB);
            displayC.Show();

            Display displayD = new SideFrame(
                new FullFrame(
                    new FullFrame(
                        new SideFrame(
                            new SideFrame(
                                new FullFrame(
                                    new MessageDisplay("See you again.")
                                    ),
                                '#'
                                ),
                            '#'
                            )
                        )
                    ),
                '#'
                );
            displayD.Show();
        }
    }
}
