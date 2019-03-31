using CreationalPatterns.Prototype.Framework;

// Display a character string enclosed with a frame line, or drawn with an underline.

namespace CreationalPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a manager
            var manager = new Manager();
            IDisplay emphasisUnderline = new UnderlineDisplay('~');
            IDisplay highlightFrame = new FrameDisplay('+');
            IDisplay warningFrame = new FrameDisplay('#');
            manager.RegisterDisplay("emphasis", emphasisUnderline);
            manager.RegisterDisplay("highlight", highlightFrame);
            manager.RegisterDisplay("warning", warningFrame);

            // Create displays
            IDisplay display1 = manager.GetDisplay("emphasis");
            display1.Show("Nice to meet you.");
            IDisplay display2 = manager.GetDisplay("highlight");
            display2.Show("Nice to meet you.");
            IDisplay display3 = manager.GetDisplay("warning");
            display3.Show("Nice to meet you.");
        }
    }
}
