using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            int z = x++ - ++y + 1;
            Console.WriteLine("Gia tri cua z la: " + z);
            Console.WriteLine("Gia tri cua x la: " + x);
            Console.ReadKey();
            //Step 1: ++y => y = 3;
            //Step 2: x = 1, y = 3 => 1 - 3 + 1 = -1;
            //Step 3: z = -1;
            //Step 4: x++ => x = 2;
        }
    }
}
