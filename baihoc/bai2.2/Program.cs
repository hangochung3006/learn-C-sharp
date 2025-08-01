using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen;
            float diemToan, diemVan;
            Console.WriteLine("Mời bạn nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào điểm toán: ");
            diemToan = float.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào điểm văn: ");
            diemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Học sinh tên {0} có điểm toán là: {1}, điểm văn là: {2}", hoTen, diemToan, diemVan);
            Console.ReadKey();
        }
    }
}
