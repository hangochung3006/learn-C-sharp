using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1, Viết chương trình cho phép người dùng nhập vào số nguyên a
            int a;
            Console.WriteLine("Hay nhap a: ");
            a = int.Parse(Console.ReadLine());
            //2, Nhập a=5 , thực hiện các phép tính sau:
            //2.A a+=3
            Console.WriteLine("a += 3: " + (a += 3));
            a = 5;
            //2.B a-=5
            Console.WriteLine("a -= 5: " + (a - +5));
            a = 5;
            //2.C a*=2
            Console.WriteLine("a *= 2: " + (a *= 2));
            a = 5;
            //2.D a/=9
            Console.WriteLine("a /= 9: " + (a /= 9));
            a = 5;
            //2.E a%=5
            Console.WriteLine("a %= 5: " + (a %= 5));
            a = 5;
            //F cho b=2, rút gọn biểu thức a=a-(b+7);
            int b = 2;
            Console.WriteLine("a = a - (b + 7): " + (a -= (b + 7)));
            Console.ReadKey();
        }
    }
}
