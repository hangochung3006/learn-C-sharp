using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int dayN = 1, j = 1;
            //for(int i = 1; i <= n; i++)
            //{
            //    dayN *= i;
            //}
            //Console.WriteLine("Tich N! = " + dayN);
            while(j <= n)
            {
                dayN *= j;
                j++;
            }
            Console.WriteLine("Tich N! = " + dayN);
            Console.ReadLine();
        }
    }
}
