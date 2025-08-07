using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(2001, 06, 30);
            Console.WriteLine("Ngay sinh cua toi la: " + birthday.ToString("dd/MM/yyyy"));

            DateTime today = DateTime.Now;
            Console.WriteLine("Bay gio dang la:" + today);

            DateTime birthday2 = DateTime.Parse("2001/06/30");
            Console.WriteLine("Ngay sinh cua toi la: " + birthday2.ToString("dd/MM/yyyy"));
            //Viết chương trình nhập vào ngày sinh của bạn và in ra ngày sinh đó theo định dạng dd/MM/yyyy
            //int year, day, month;
            //Console.Write("Nhap vao nam sinh cua ban: ");
            //year = int.Parse(Console.ReadLine());
            //Console.Write("Nhap vao thang sinh cua ban: ");
            //month = int.Parse(Console.ReadLine());
            //Console.Write("Nhap vao ngay sinh cua ban: ");
            //day = int.Parse(Console.ReadLine());
            //DateTime ngaySinh = new DateTime(year, month, day);
            //Console.WriteLine("Ngay sinh cua ban da nhap la: " + ngaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Nhap ngay sinh cua ban (ngay/thang/nam): ");
            string s = Console.ReadLine();
            DateTime birthday3 = DateTime.Parse(s);
            Console.WriteLine("Ngay sinh ban vua nhap la: " + birthday3.ToString("dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
