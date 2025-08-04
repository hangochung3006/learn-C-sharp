using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nam;
            Console.WriteLine("Hay nhap vao so nam: ");
            nam = int.Parse(Console.ReadLine());
            if ((nam % 4 == 0) && (nam % 100 != 0) || (nam % 400 == 0))
            {
                Console.WriteLine("Nam {0} la nam nhuan", nam);
            }
            else
            {
                Console.WriteLine("Nam {0} khong phai la nam nhuan", nam);
            }
            Console.ReadKey();
        }
    }
}
    