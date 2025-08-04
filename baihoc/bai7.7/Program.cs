using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang;
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            if (thang == 1 || thang == 2 || thang == 3)
            {
                Console.WriteLine("Thang {0} thuoc quy 1", thang);
            }
            else if (thang == 4 || thang == 5 || thang == 6)
            {
                Console.WriteLine("Thang {0} thuoc quy 2", thang);
            }
            else if (thang == 7 || thang == 8 || thang == 9)
            {
                Console.WriteLine("Thang {0} thuoc quy 3", thang);
            }
            else
                Console.WriteLine("Thang {0} thuoc quy 4", thang);
            }
        }
    }

