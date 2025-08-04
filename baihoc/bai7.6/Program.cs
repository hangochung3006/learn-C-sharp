using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, a, b, c;
            double delta;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            delta = Math.Pow(b,2) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Phuong trinh nghiem kep: x1 = x2 = " + x1);
            }
            else
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
            }

        }
    }
}
