using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace bai15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] tachKyTu = str1.Split(' ');
            string danhSachSo = "";
            int tong = 0, tbc = 0, dem = 0;
            foreach (string s in tachKyTu)
            {
                foreach (char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        danhSachSo += s + " ";
                        break;
                    }
                }
            }
            danhSachSo = danhSachSo.Trim();
            string[] tachSo = danhSachSo.Split(' ');
            foreach (string so in tachSo)
            {
                tong += int.Parse(so);
                dem++;
            }
            tbc = tong / dem;
            Console.WriteLine("Tong cua day so tren la " + tong);
            Console.WriteLine("Trung binh cong la " + tbc);
            Console.ReadKey();
        }
    }
}
