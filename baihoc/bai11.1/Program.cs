using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,3,5,7,8,10,12,13};
            int thang;
            Console.Write("Hay nhap thang muon kiem tra: ");
            thang = int.Parse(Console.ReadLine());
            if (thang < 1 || thang > 12)
            {
                Console.WriteLine("Thang khong hop le");
                return;
            }
            foreach (int i in a)
            {
                if (i == thang)
                {
                    Console.WriteLine("Thang {0} co 31 ngay", thang);
                    break;
                }
                else if(i == 13)
                {
                    Console.WriteLine("Thang {0} co 30 ngay", thang);
                }
            }
        }
    }
}
