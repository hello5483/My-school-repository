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
            string Digits = "0123456789";
            string Characters = "abcdABCD@#!£";
            string Alphanumerics = Digits + " " + Characters;
            Console.WriteLine("The digits are: " + Digits);
            Console.WriteLine("The characters are: " + Characters);
            Console.WriteLine("The alphanumerics are: " + Alphanumerics);
            Console.ReadLine();
        }
    }
}

