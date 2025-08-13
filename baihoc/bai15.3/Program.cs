using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bai15._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string matKhauDung = "HaNgocHung3006";
            string matKhau;
            int kyTuChu = 0, kyTuSo = 0, lanDangNhap = 5;    
            Console.Write("Hãy nhập mật khẩu:");
            matKhau = Console.ReadLine();
            char[] kyTu = matKhau.ToCharArray();
            bool check = true;
            while (check)
            {
                foreach (char c in kyTu)
                {
                    if (char.IsLetter(c))
                        kyTuChu++;
                    else if (char.IsDigit(c))
                        kyTuSo++;
                }
                if (kyTuChu*kyTuSo != 0 && matKhau.Length >= 6)
                {
                    if (matKhau.Equals(matKhauDung))
                    {
                        Console.WriteLine("Đăng nhập thành công");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sai mật khẩu");
                        { }
                    }
                }
                else
                {
                    Console.WriteLine("Nhập lại mật khẩu (có ít nhất 6 ký tự, 1 ký tự số, 1 ký tự chữ): ");
                    matKhau = Console.ReadLine();
                    check = true;
                }
            }
        }
    }
}
