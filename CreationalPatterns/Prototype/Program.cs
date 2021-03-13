using CreationalPatterns.Prototype.Framework;

/*
Display a string enclosed with a frame line, or drawn with an underline. The Client (Main)
registers instances of the Display subclass in the Manager class. When necessary,
the Manager class asks those registered instances to return a clone. The Client (Main)
requires the returned clones to display.
 */

namespace CreationalPatterns.Prototype
{
    class Program
    {
        static void Main()
        {
            Manager manager = new Manager();

            // Register instances of the "Display" subclass
            IDisplay emphasisUnderline = new UnderlineDisplay('~');
            manager.RegisterDisplay("emphasis", emphasisUnderline);
            IDisplay highlightFrame = new FrameDisplay('+');
            manager.RegisterDisplay("highlight", highlightFrame);
            IDisplay warningFrame = new FrameDisplay('#');
            manager.RegisterDisplay("warning", warningFrame);

            // Require to display
            IDisplay display1 = manager.GetDisplay("emphasis");
            display1.Show("Nice to meet you.");
            IDisplay display2 = manager.GetDisplay("highlight");
            display2.Show("Nice to meet you.");
            IDisplay display3 = manager.GetDisplay("warning");
            display3.Show("Nice to meet you.");
        }
    }
}
