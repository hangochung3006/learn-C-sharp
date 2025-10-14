using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            string ketQua = "";
            Console.WriteLine("Hay nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            if(a % 2 == 0)
            {
                for(int i = 0; i <= a; i+=2)
                {
                    tong += i;
                    if(i == a)
                    {
                        ketQua += i;
                        break;
                    }
                    else { 
                        ketQua += i + " + "; 
                    }
                }
                Console.WriteLine("Tong cac so le tu 0 -> a = {0} = {1}", ketQua, tong);
            }
            else
            {
                Console.WriteLine("Toi khong tinh so le, bye bye");
            }
        }
    }
}
