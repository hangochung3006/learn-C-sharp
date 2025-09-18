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
        //Tham trị
        static void thamTri(int a)
        {
            a = a + 1;
            Console.WriteLine("a trong ham la: " + a);
        }
        //Tham chiếu Ref
        static void thamChieuRef(ref int b)
        {
            b++;
            Console.WriteLine("b trong ham la: " + b);
        }
        //Tham chiếu Out
        static void thamChieuOut(out int c)
        {
            c = 2;
            Console.WriteLine("c trong ham la: " + c);
        }
        static void Main(string[] args)
        {
            int c;
            thamChieuOut(out c);
            Console.WriteLine("c sau khi goi ham la: " + c);






            //Tham chiêu Ref
            int b = 1;
            Console.WriteLine("b truoc khi goi ham la: " + b);
            thamChieuRef(ref b);
            Console.WriteLine("b sau khi goi ham la: " + b);

            //Tham trị
            int a = 1;
            Console.WriteLine("a truoc khi goi ham la: " + a);
            thamTri(a);
            Console.WriteLine("a sau khi thuc hien ham tren: " + a);

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
