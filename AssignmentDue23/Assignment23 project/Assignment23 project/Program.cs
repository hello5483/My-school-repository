using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23_project
{
    internal class Program
    {
        static void OutputElementInfo(string Element)
        {
            string ElementName = "";
            string AtomicWeight = "";
            string Group = "";
            switch (Element)
            {
                case "F":
                    ElementName = "Flourine";
                    AtomicWeight = "9";
                    Group = "7";
                    break;
                case "Cl":
                    ElementName = "Chlorine";
                    AtomicWeight = "17";
                    Group = "7";
                    break;
                case "Br":
                    ElementName = "Bromine";
                    AtomicWeight = "35";
                    Group = "7";
                    break;
                case "He":
                    ElementName = "Helium";
                    AtomicWeight = "2";
                    Group = "8";
                    break;
                case "Ne":
                    ElementName = "Neon";
                    AtomicWeight = "10";
                    Group = "8";
                    break;
                case "Ar":
                    ElementName = "Argon";
                    AtomicWeight = "18";
                    Group = "8";
                    break;
                 
            }
            Console.WriteLine("Element: ", ElementName);
            Console.WriteLine("Atomic weight: ", AtomicWeight);
            Console.WriteLine("Group: ", Group);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            //OutputElementInfo()
        }
    }
}
