using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n =");
            n = int.Parse(Console.ReadLine());
            while (n > 99 || n < 0)
            {
                Console.WriteLine("Hay nhap lai");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ban da nhap xong vs n = " + n);
            Console.ReadKey();
        }
    }
}
