using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Nhập vào điểm trung bình và kết quả xếp loại của học sinh theo tiêu chuẩn sau:
             - Giỏi: Nếu điểm >= 8 
             - Khá: Nếu 8 > điểm >= 6.5
             - Trung bình: Nếu 6.5 > điểm >= 5
             - Yếu: Nếu điểm < 5
             */
            Console.OutputEncoding = Encoding.UTF8;
            float diemTrungBinh;
            Console.WriteLine("Moi ban nhap diem trung binh cua minh: ");
            diemTrungBinh = float.Parse(Console.ReadLine());
            if (diemTrungBinh >= 8)
                Console.WriteLine("Bạn là học sinh giỏi!");
            else if (diemTrungBinh < 8 && diemTrungBinh >= 6.5)
                Console.WriteLine("Bạn là học sinh khá!");
            else if (diemTrungBinh < 6.5 && diemTrungBinh >= 5)
                Console.WriteLine("Bạn là học sinh trung bình!");
            else
                Console.WriteLine("Bạn là học sinh kém");
            Console.ReadKey();
        }
    }
}
