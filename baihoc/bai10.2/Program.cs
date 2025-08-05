using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tính tổng các số từ 1 - 5
            int a = 1;
            int tong = 0;
            do
            {
                tong += a;
                a++;
            } while (a <= 5);
            Console.WriteLine("Tong tu 1 den 5 la: " + tong);
        }
    }
}
