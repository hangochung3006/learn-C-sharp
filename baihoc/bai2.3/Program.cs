using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var y = 113;
            Console.WriteLine("Kiểu dữ liệu của y là {0}", y.GetType().ToString());
            var z = "Hưng";
            Console.WriteLine("Kiểu dữ liệu của z là {0}", z.GetType().ToString());
            var k = 1.5;
            Console.WriteLine("Kiểu dữ liệu của k là {0}", k.GetType().ToString());
            Console.ReadKey();
        }
    }
}
