// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Observer
{
    // Display values as a bar chart.
    public class BarChartObserver : IObserver
    {
        // ˅
        
        // ˄

        private readonly NumberSubject numberSubject;

        public BarChartObserver(NumberSubject numberSubject)
            // ˅
            
            // ˄
        {
            // ˅
            this.numberSubject = numberSubject;
            // ˄
        }

        public void Update(Subject changedSubject)
        {
            // ˅
            if (changedSubject == numberSubject)
            {
                Console.Write("Bar chart: ");
                for (int i = 0; i < numberSubject.Value; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
