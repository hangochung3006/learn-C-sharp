using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kq, kq1;
            int a = 6, b = 18;
            kq = (a != b) || (a < 3);
            kq1 = (a != b) && (a < 3);
            Console.WriteLine("Gia tri cua ket qua kq la: " + kq);
            Console.WriteLine("Gia tri cua ket qua kq1 la: " + kq1);
            Console.ReadKey();
        }
    }
}
