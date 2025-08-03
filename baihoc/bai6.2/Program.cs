using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, s, p;
            Console.WriteLine("Hay nhap chieu dai a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap chieu rong b: ");
            b = float.Parse(Console.ReadLine());
            s = a * b; //diện tích hình chữ nhật
            p = (a + b) * 2; //chu vi hình chữ nhật
            Console.WriteLine("Dien tich hcn là: " + s);
            Console.WriteLine("Chu vi hcn là: " + p);
            Console.ReadKey();
        }
    }
}
