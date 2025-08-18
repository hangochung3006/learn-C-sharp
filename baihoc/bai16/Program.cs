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

            //Truy xuất phần tử qua index
            int[] mangXuat = { 1, 3, 5 };
            Console.WriteLine(mangXuat[1]);
            Console.WriteLine(mangXuat[mangXuat.Length-1]); //Phần từ cuối cùng của mảng

            //Thay đổi giá trị phần tử của mảng bằng cách gọi index
            int[] mangThayDoi = { 1, 3, 5 };
            Console.WriteLine("Gia tri truoc khi doi: " + mangThayDoi[1]);
            mangThayDoi[1] = 12;
            Console.WriteLine("Gia tri sau khi thay doi: " + mangThayDoi[1]);

            //Duyệt mảng for
            int[] mang1 = new int[] { 1, 4, 5 };
            for(int i = 0; i < mang1.Length; i++)
            {
                Console.WriteLine(mang1[i]);
            }

            //Duyệt mảng foreach
            int[] mang2 = new int[] { 4, 8, 10, 26, 33 };
            foreach (int so in mang2)
            {
                Console.WriteLine(so);
            }

            //Phép gán mảng
            int[] mang3 = new int[] { 55, 22, 33, 44, 66 };
            int[] mangGan = mang3;
            Console.WriteLine(mang3[1]);
            Console.WriteLine(mangGan[1]);
            mangGan[1] = 4124124;
            Console.WriteLine(mang3[1]);
            Console.WriteLine(mangGan[1]);

            //CopyTo
            int[] mang4 =  { 1, 2, 3, 4, 5 };
            int[] mangCopyTo =  { 100, 200, 300, 400, 500, 600, 700};
            mang4.CopyTo(mangCopyTo, 1); // Copy từ mang4 vào mangCopyTo bắt đầu từ vị trí index 1
            foreach (var item in mangCopyTo)
            {
                Console.Write(item + " ");
            }

            //Copy
            int[] mang5 = { 2, 3, 4, 5, 7 };
            int[] mangCopy = { 99, 100, 101 };
            Array.Copy(mang5, mangCopy, 3); 
            // Sao chép 3 phần tử đầu tiên từ mang5 vào mangCopy
            Console.WriteLine();
            foreach (var item in mangCopy)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Clone
            int[] mang6 = { 8, 2, 4, 6, 3, 7 };
            int[] mangClone = (int[])mang6.Clone();
            mang6[0] = 99;
            Console.WriteLine(mang6[0]);
            Console.WriteLine(mangClone[0]);

            //Array.Reverse
            int[] mang7 = new int[] { 1, 5, 3, 4, 5 };
            Array.Reverse(mang7);
            foreach(int so in mang7)
            {
                Console.Write(so + " ");
            }

            //Array.Sort()
            int[] mang8 = { 1, 6, 44, 22, 22, 22, -2, -5, -3 };
            Array.Sort(mang8);
            foreach(int so in mang8)
            {
                Console.Write(so + " ");
            }
            Console.ReadKey();

        }
    }
}
