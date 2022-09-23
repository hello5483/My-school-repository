using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double CellSizeUm = 80;
            double CellSizeCm = CellSizeUm / 10000;
            double SlideCellSize = 4;

            Console.WriteLine("The magnification is " + SlideCellSize / CellSizeCm + "X");
            Console.ReadLine();
        }
    }
}

