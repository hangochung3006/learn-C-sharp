using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bai7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y, tong, hieu;
            Console.WriteLine("Tong cua hai so la: ");
            tong = float.Parse(Console.ReadLine());
            Console.WriteLine("Hieu cua hai so la: ");
            hieu = float.Parse(Console.ReadLine());
            x = (tong + hieu) / 2;
            y = (tong - hieu) / 2;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.ReadKey();
        }
    }
}
