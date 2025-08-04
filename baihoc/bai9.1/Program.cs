using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHUONG TRINH TIM KIEM");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Tim kiem theo ten");
            Console.WriteLine("2. Tim kiem theo tac gia");
            Console.WriteLine("3. Tim kiem theo nha xuat ban");
            Console.WriteLine("4. Tim kiem theo tieu de");
            Console.ReadKey();
        }
    }
}
