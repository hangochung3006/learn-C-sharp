using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 1;
            int b = 2;
            float c = a / b;
            Console.WriteLine("Giá trị của c là: " + c);
            float c2 = (float) a / b;
            Console.WriteLine("Giá trị của c2 là: " + c2);
            Console.WriteLine();
            int d = 40000;
            byte k = (byte)d;
            Console.WriteLine("d = " + d);
            Console.WriteLine("k = " + k);
            Console.ReadLine();
        }
    }
}
