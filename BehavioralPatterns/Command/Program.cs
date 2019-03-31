using System;
using System.Windows.Forms;

// Simple drawing application.

namespace BehavioralPatterns.Command
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppMain());
        }
    }
}
