using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            Console.WriteLine("Hay nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                Console.WriteLine("Thang {0} co 30 ngay", thang);
            }
            else if (thang == 2)
            {
                Console.WriteLine("Hay nhap them so nam: ");
                nam = int.Parse(Console.ReadLine());
                if(nam % 4 == 0 && (nam % 100 != 0 || nam % 400 == 0))
                {
                    Console.WriteLine("Thang {0} co 29 ngay", thang);
                }
                else
                {
                    Console.WriteLine("Thang {0} co 28 ngay", thang);
                }
            }
            else
            {
                Console.WriteLine("Thang {0} co 31 ngay", thang);
            }
        }
    }
}
