using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemTotNghiep;
            Console.WriteLine("Moi nhap diem tot nghiep ");
            diemTotNghiep = float.Parse(Console.ReadLine());
            //check điều kiện
            if (diemTotNghiep > 7)
            {
                Console.WriteLine("Chuc mung ban da do");
            }else
            {
                Console.WriteLine("Ban da truot!");
            }
            Console.ReadKey();
        }
    }
}
