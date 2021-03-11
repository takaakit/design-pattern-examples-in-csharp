/*
Observers observe objects generating a numerical value and display the value.
The display formats are digits and bar charts.
 */

namespace BehavioralPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new RandomNumber();
            number.AddObserver(new DigitObserver());
            number.AddObserver(new BarChartObserver());
            number.Generate();
        }
    }
}
