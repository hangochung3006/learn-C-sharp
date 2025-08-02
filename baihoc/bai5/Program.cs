using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r;
            float pi = 3.14f;
            float chuVi, dienTich;
            Console.WriteLine("Moi ban nhap chu vi r: ");
            r = float.Parse(Console.ReadLine());
            chuVi = 2 * r * pi;
            dienTich = pi * r * r;
            Console.WriteLine("Chu vi hinh tron la: " + chuVi);
            Console.WriteLine("Dien tich hinh tron la: " + dienTich);
            Console.ReadKey();
        }
    }
}
