using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Pi
            Console.WriteLine("PI = " + Math.PI);
            Console.WriteLine("Kieu du lieu cua Math.PI = " + Math.PI.GetType().ToString());
            //Math.Sqrt
            Console.WriteLine("Test Math.Sqrt(4) = " + Math.Sqrt(4));
            Console.WriteLine("Kieu du lieu cua Math.Sqrt(4) " + Math.Sqrt(4).GetType().ToString());
            //Math.Pow
            Console.WriteLine("Test Math.Pow(2,2) = " + Math.Pow(2,2));
            Console.WriteLine("Kieu du lieu cua Math.Pow(2,2) " + Math.Pow(2,2).GetType().ToString());
            //Math.Round
            Console.WriteLine("Test Math.Round(2.3123) = " + Math.Round(2.3123));
            Console.WriteLine("Kieu du lieu cua Math.Round(2.3123) " + Math.Round(2.3123).GetType().ToString());
            //Math.Abs
            Console.WriteLine("Test Math.Abs(-5) = " + Math.Abs(-5));
            Console.WriteLine("Kieu du lieu cua Math.Abs(-5) " + Math.Abs(-5).GetType().ToString());
            //Math.Max
            Console.WriteLine("Test Math.Max(2,4) = " + Math.Max(2, 4));
            Console.WriteLine("Kieu du lieu cua Math.Max(2,4) " + Math.Max(2, 4).GetType().ToString());
            //Math.Sin
            Console.WriteLine("Test Math.Sin(Math.PI) = " + Math.Sin(Math.PI));
            Console.WriteLine("Kieu du lieu cua Math.Sin(Math.PI) " + Math.Sin(Math.PI).GetType().ToString());
            Console.ReadKey();
        }
    }
}
