using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void CalculateCost(double PreviousReading, double CurrentReading, double CalorificValue)
        {
            double UnitsUsed = CurrentReading - PreviousReading;
            double kWhUsed = UnitsUsed * 1.022 * CalorificValue / 3.6;
            Console.WriteLine(kWhUsed * 2.84);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            double CalorificValue = 39.3;
            double PreviousReading = 20;
            double CurrentReading = 25;

            CalculateCost(PreviousReading, CurrentReading, CalorificValue);
        }
    }
}

