using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai21
{
    internal class Program
    {
        static void ngoaiLe()
        {
            try
            {
                Console.WriteLine("Moi nhap vao ngay thang nam sinh: ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Ngay sinh cua ban la: " + birthday.ToString("dd/MM/yyyy"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ket thuc chuong trinh");
            }
        }

        static void ngoaiLe2()
        {
            Console.WriteLine("Moi nhap vao tu so: ");
            int tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap vao mau so: ");
            int mauSo = int.Parse(Console.ReadLine());
            if (mauSo == 0)
            {
                throw new ArithmeticException("Mau so khong the bang 0");
            }
        }
        static void Main(string[] args)
        {
            try
            { 
                ngoaiLe2();
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
