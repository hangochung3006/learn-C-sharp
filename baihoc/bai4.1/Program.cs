using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("So {0} la so {1}", n, (n % 2 == 0) ? "chan" : "le");
            Console.ReadKey();
        }
    }
}
