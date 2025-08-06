using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Xuất các số chẵn từ 0 - 10
            int a = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    a += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Tong cac so chan tu 0 - 10 la: " + a);
            Console.ReadKey();
        }
    }
}
