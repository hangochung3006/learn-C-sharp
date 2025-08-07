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
            //cách 1
            char kyTu = 'a';
            Console.WriteLine("Ky tu: " + kyTu);
            Console.WriteLine(kyTu.GetType().ToString());
            //cách 2
            char kyTu2 = (char)64;
            Console.WriteLine("Ky tu 2: " + kyTu2);
            Console.WriteLine(kyTu2.GetType().ToString());
            //ép kiểu char cho dỡ liệu nhập vào
            char kyTu3 = char.Parse("b");
            Console.WriteLine("Ky tu 3: " + kyTu3);
            Console.WriteLine(kyTu3.GetType().ToString());
            //chuyển đổi dữ liệu
            char kyTu4 = Convert.ToChar("c");
            Console.WriteLine("Ky tu 4: " + kyTu4);
            Console.WriteLine(kyTu4.GetType().ToString());
            Console.ReadKey();
        }
    }
}
