using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> taiKhoan = new Dictionary<string, string>();
            List<string> user = new List<string>() { "Hung", "Huyen", "Mimi" };
            List<string> pass = new List<string>() { "123Hung", "123Huyen", "123Mimi" };
            for(int i = 0; i < user.Count(); i++)
            {
                taiKhoan.Add(user[i], pass[i]);
            }
            Console.WriteLine("Moi ban nhap tai khoan: ");
            string a = Console.ReadLine();
            bool checkTaiKhoan = taiKhoan.ContainsKey(a);
            while (checkTaiKhoan == false)
            {
                Console.WriteLine("Tai khoan nay khong ton tai");
                Console.WriteLine("Hay nhap lai tai khoan: ");
                a = Console.ReadLine();
                checkTaiKhoan = taiKhoan.ContainsKey(a);
            }
            Console.WriteLine("Moi ban nhap mat khau: ");
            string b = Console.ReadLine();
            while (taiKhoan[a] != b)
            {
                Console.WriteLine("Sai mat khau!");
                Console.WriteLine("Moi ban nhap lai mat khau cho tai khoan {0}: ", a);
                b = Console.ReadLine();
            }
            Console.WriteLine("Ban da dang nhap thanh cong!");
            Console.ReadKey();
        }
    }
}
