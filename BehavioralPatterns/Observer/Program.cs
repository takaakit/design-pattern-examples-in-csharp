using System;

/*
Observers observe a Subject object holding a numerical value and display the value.
The display formats are digits and bar charts.
 */

namespace BehavioralPatterns.Observer
{
    class Program
    {
        static void Main()
        {
            NumberSubject numberSubject = new NumberSubject();
            numberSubject.Attach(new DigitObserver(numberSubject));
            numberSubject.Attach(new BarChartObserver(numberSubject));

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                numberSubject.Value = random.Next(50);
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
