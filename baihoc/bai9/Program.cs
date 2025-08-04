using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhập vào 1 số, kiểm tra chẵn hay lẻ dùng switch case
            int a;
            Console.Write("Nhap so: ");
            a = int.Parse(Console.ReadLine());
            int div = a % 2;
            switch (div)
            {
                case 0:
                    Console.WriteLine("Day la so chan");
                    goto case 1;
                case 1:
                    Console.WriteLine("Day la so le");
                    break;
            }
            Console.ReadKey(); 
        }
    }
}
