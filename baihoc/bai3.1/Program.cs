using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("Nhap x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y: ");
            y = float.Parse(Console.ReadLine());
            float z = x + y;
            float z1 = x - y;
            float z2 = x * y;
            float z3 = x / y;
            float z4 = x % y;
            Console.WriteLine("{0} + {1} = {2}", x,y,z);
            Console.WriteLine("{0} - {1} = {2}", x,y,z1);
            Console.WriteLine("{0} * {1} = {2}", x,y,z2);
            Console.WriteLine("{0} / {1} = {2}", x,y,z3);
            Console.WriteLine("{0} % {1} = {2}", x,y,z4);
            Console.ReadLine();
        }
    }
}
