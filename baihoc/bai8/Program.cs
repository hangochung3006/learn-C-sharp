using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhập vào 1 số n, kiểm tra n là chẵn hay lẻ;
            int n;
            string a;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            a = (n % 2 == 0) ? "chan" : "le";
            Console.WriteLine("n la so " + a);
            Console.ReadKey();
        }
    }
}
