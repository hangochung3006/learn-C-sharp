using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char kyTu = 'a';
            Console.WriteLine("Ky tu: " + kyTu);
            Console.WriteLine(kyTu.GetType().ToString());
            char kyTu2 = (char)64;
            Console.WriteLine("Ky tu 2: " + kyTu2);
            Console.ReadKey();
        }
    }
}
