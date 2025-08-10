using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace bai15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot day ky tu: ");
            string chuoi = Console.ReadLine();
            char[] kyTu = chuoi.ToCharArray();
            int kyTuThuong = 0, kyTuSo = 0, dauCach = 0;
            foreach (char c in kyTu)
            {
                if (Char.IsLower(c))
                    kyTuThuong++;
                else if (Char.IsNumber(c))
                    kyTuSo++;
                else if (Char.IsWhiteSpace(c))
                    dauCach++;
            }
            Console.WriteLine("Co tat ca {0} ky tu thuong, {1} ky tu so, {2} dau cach trong chuoi {3}", kyTuThuong, kyTuSo, dauCach, chuoi);
        }
    }
}
