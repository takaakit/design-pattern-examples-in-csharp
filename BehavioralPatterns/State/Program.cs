using System;
using System.Windows.Forms;

// Safe security system that the security status changes with time.

namespace BehavioralPatterns.State
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppSafe());
        }
    }
}
