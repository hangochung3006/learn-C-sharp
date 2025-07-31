using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int soLuong; //khai báo biến
            string hoTen = "Hà Ngọc Hưng"; //khởi tạo biến
            byte tuoi; //khai báo biến
            double diemToan = 8; //khởi tạo biến
            float diemTB = 6.5f; //khởi tạo biến, riêng kiểu float thì phải có chữ f ở cuối
            Console.WriteLine("Họ tên là {0}", hoTen);
            Console.WriteLine("Họ tên là {0}, Điểm toán là {1}, Điểm trung bình là {2}", hoTen, diemToan, diemTB);
            Console.ReadLine(); 
        }
    }
}
