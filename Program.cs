using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras_Theorem_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of Base from the right angle triangle:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of Perpendicular from the right angle triangle:");
            double p = Convert.ToDouble(Console.ReadLine());
            double h = Math.Sqrt((b * b) + (p * p));
            Console.WriteLine("The value of Hypotenuese of the right angle triangle with given base " + b + " and perpendicular " + p + " is " + h + ".");  

        }
    }
}
