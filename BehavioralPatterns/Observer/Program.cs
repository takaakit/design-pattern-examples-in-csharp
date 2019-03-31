// Observers observe objects generating a numerical value and display the value.

namespace BehavioralPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new RandomNumber();
            var digitObserver = new DigitObserver();
            var barChartObserver = new BarChartObserver();
            number.AddObserver(digitObserver);
            number.AddObserver(barChartObserver);
            number.Generate();
        }
    }
}
