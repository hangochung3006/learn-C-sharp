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

            SinhVien sinhVien1 = new SinhVien();
            Console.WriteLine(sinhVien1.MaSV);
            Console.WriteLine(sinhVien1.TenSV);
            Console.WriteLine(sinhVien1.Tuoi);
            Console.WriteLine(sinhVien1.Lop);
            Console.ReadKey();

        }
    }
}
