using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HocSinh hocsinh1 = new HocSinh(123, "Hung", 25);
            HocSinh hocsinh2 = new HocSinh();
            hocsinh2.maHS = 456;
            hocsinh2.tenHS = "Huyen";
            hocsinh2.tuoi = 25;
            Console.WriteLine(hocsinh1);
            Console.WriteLine(hocsinh2);

            //SinhVien sinhVien1 = new SinhVien();
            //SinhVien sinhVien2 = new SinhVien(2, "Nguyen Thanh Huyen", 25, "CNTT1", 15);

            //Console.WriteLine(sinhVien1.diemTrungBinh(2, 3, 4, 5, 6, 7, 8));
            //Console.WriteLine(sinhVien2.diemTrungBinh(2, 3, 4, 5, 6, 7, 8, 19, 22, 33));
            //Console.WriteLine(sinhVien1.Tong(2, 3));
            //Console.WriteLine(sinhVien1.Tong(1, 2, 3, 4));
            //Console.WriteLine(sinhVien1.Tong(1.2, 2.3));

            //sinhVien1.xuatThongTin();
            //Console.WriteLine("\n");
            //sinhVien2.xuatThongTin();

            //Console.WriteLine(sinhVien1);
            //Console.WriteLine(sinhVien1.ToString());
            //Console.WriteLine(sinhVien1.Tong(2, 3));
            //Console.WriteLine(sinhVien1.Tong(1, 2, 3, 4));
            //Console.WriteLine(sinhVien1.Tong(1.2, 2.3));

            Console.ReadKey();

        }
    }
}
