using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static double CalculateCost(double RoomWidth, double RoomLength, double PricePerSquareMeter)
        {
            double GripperPrice = (RoomWidth * 2) + (RoomLength * 2);
            return (RoomWidth * RoomLength * PricePerSquareMeter) + GripperPrice + 50;
        }
        static void Main(string[] args)
        {
            double RoomWidth = 7;
            double RoomLength = 6;
            double PricePerSquareMeter = 17 + 3;

            Console.WriteLine(CalculateCost(RoomWidth, RoomLength, PricePerSquareMeter));
            Console.ReadLine();

        }
    }
}

