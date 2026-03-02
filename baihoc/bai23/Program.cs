using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanVien1 = new NhanVien();
            nhanVien1.MaNV = 123;
            nhanVien1.TenNV = "Hung";
            nhanVien1.Luong = 100000000;
            Console.WriteLine(nhanVien1);

            NhanVienDiCa nhanVienDiCa1 = new NhanVienDiCa();
            nhanVienDiCa1.MaNV = 789;
            nhanVienDiCa1.TenNV = "Mimi";
            nhanVienDiCa1.Luong = 123123123;
            nhanVienDiCa1.CaLam = "Dem";
            Console.WriteLine(nhanVienDiCa1);


            //NhanVienHanhChinh nhanVienHC1 = new NhanVienHanhChinh();
            //nhanVienHC1.MaNV = 456;
            //nhanVienHC1.TenNV = "Huyen";
            //nhanVienHC1.Luong = 1000000000;
            //Console.WriteLine(nhanVienHC1);


            Console.ReadKey();
        }
    }
}
