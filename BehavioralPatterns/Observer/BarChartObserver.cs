// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // Display values with a bar chart.
    public class BarChartObserver : IObserver
    {
        // ˅
        
        // ˄

        public void Update(Number number)
        {
            // ˅
            Console.Write("Bar chart: ");
            for (int i = 0; i < number.Value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(100);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
