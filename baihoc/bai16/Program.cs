using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo mảng
            int[] stt;
            string[] diachi;
            //Khởi tạo mảng
            string[] ten = new string[10];
            diachi = new string[10];
            //Khởi tạo và gán luôn giá trị cho mảng
            int[] sdt = new int[2] { 1232757, 8124812 };
            int[] sdt2 = { 1232757, 8124812, 1234567, 7654321 };
            foreach (var item in sdt)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            foreach (var item in sdt2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Khởi tạo mảng ngẫu nhiên
            Random ngauNhien = new Random();
            int[] mangNgauNhien = new int[3] { ngauNhien.Next(2), ngauNhien.Next(64), ngauNhien.Next(72) };
            foreach (var item in mangNgauNhien)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Length
            int[] doDaiMang = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Chieu dai cua mang la: " + doDaiMang.Length);
            Console.ReadKey();
        }
    }
}
