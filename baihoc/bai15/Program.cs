using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao thuong
            string hoTen = "Ha Ngoc Hung";
            Console.WriteLine("Ten toi la " + hoTen);
            //Khai bao nguyen van
            string duongDan = @"C:\Users\ASUS\Desktop\learn-C-sharp";
            Console.WriteLine(duongDan);
            //Khai bao dung /
            string viDu = "Co nguoi noi rang: \"Toi nen hoc ngon ngu C#\"";
            Console.WriteLine(viDu);


            //Biến đổi chuỗi
            int i = 1234;
            Console.WriteLine(i + " " +i.GetType().ToString());
            string chuoiSo = i.ToString();
            Console.WriteLine(chuoiSo + " " + chuoiSo.GetType().ToString());
            string chuoiSo2 = i + "";
            Console.WriteLine(chuoiSo2 + " " + chuoiSo2.GetType().ToString());
            string chuoiSo3 = Convert.ToString(i);
            Console.WriteLine(chuoiSo3 + " " + chuoiSo3.GetType().ToString());
            

            //Tách chuỗi và cho vào mảng
            string tachChuoi = "HaNgocHung";
            char[] lst = tachChuoi.ToCharArray();
            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString());
            Console.ReadKey();
        }
    }
}
