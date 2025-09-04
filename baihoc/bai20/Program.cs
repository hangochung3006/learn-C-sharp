using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20
{
    internal class Program
    {
        /// <summary>
        /// Hàm này là để tính tổng nhé.
        /// </summary>
        /// <param name="a">Nhập a là số nguyên</param>
        /// <param name="b">Nhập b là số nguyên</param>
        /// <param name="c">Nhập c là số nguyên</param>
        /// <returns>Trả về tổng a + b + c là số nguyên</returns>
        static int tinhTong(int a, int b, int c)
        {
            return a + b + c;
        }
        static int tinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
        static void xinChao(string m)
        {
            if(m == "Nam")
            {
                Console.WriteLine("Xin chao, minh la Boy");
            }
            else if(m == "Nu")
            {
                Console.WriteLine("Xin chao, minh la Girl");
            }    
        }
        
        static void Main(string[] args)
        {
            xinChao("Nam");

            int kq = tinhTong(4, 2, 6);
            Console.WriteLine("kq = "+kq);
            //Xuất giai thừa
            int k = 3;
            int kq1 = tinhGiaiThua(k);
            Console.WriteLine("Giai thua = "+kq1);
            Console.ReadKey();
        }
    }
}
