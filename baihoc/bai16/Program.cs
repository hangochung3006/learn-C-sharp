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
            Console.ReadKey();

        }
    }
}
