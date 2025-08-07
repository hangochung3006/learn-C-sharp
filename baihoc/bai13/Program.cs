using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            // (begin, sát end) begin không nhập sẽ mặc định = 0
            //.Next để lấy kiểu số nguyên
            int soNgauNhien = rd.Next(1, 100); // 1-99
            Console.WriteLine("So ngau nhien may sinh la: " + soNgauNhien);
            //.NextDouble để lấy kiểu số thực
            double soThucNgauNhien = rd.NextDouble(); // 0 - sát 1
            Console.WriteLine("So thuc ngau nhien: " + soThucNgauNhien);
            // Lấy số thực ngẫu nhiên trong khoảng từ 1 đến 10
            double soThucNgauNhien1Den10 = rd.NextDouble() + rd.Next(1,10); // 1 - 10
            Console.WriteLine("So thuc ngau nhien trong khoang tu 1 - 10: " + soThucNgauNhien1Den10);
            Console.ReadKey();
        }
    }
}
