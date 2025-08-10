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
            Console.WriteLine(i + " " + i.GetType().ToString());
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


            //Độ dài của chuỗi
            string doDai = "Ha Ngoc Hung";
            Console.WriteLine("Do dai chuoi la " + doDai.Length);
            Console.WriteLine("Ky tu thu nhat la: " + doDai[0]);

            //So sánh chuỗi
            string chuoi1 = "Ha Ngoc Hung";
            string chuoi2 = "Ha Ngoc Hai";
            string chuoi3 = "Ha Ngoc Hung";
            int soSanh = chuoi1.CompareTo(chuoi2);
            int soSanh2 = chuoi1.CompareTo(chuoi3);
            Console.WriteLine(soSanh);
            Console.WriteLine(soSanh2);


            //Kiểm tra chuỗi con
            string chuoi4 = "Sieu nhan Gao";
            string chuoi5 = "Sieu nhan";
            bool chuoiCon = chuoi4.Contains(chuoi5);
            Console.WriteLine(chuoiCon);

            //Hàm CopyTo
            string chuoiCopyTo = "123456";
            char[] hamCopyTo = new char[6]; //Khởi tạo mảng ký tự với kích thước 6
            hamCopyTo[0] = 'a';
            hamCopyTo[1] = 'b';
            Console.WriteLine(hamCopyTo);
            chuoiCopyTo.CopyTo(0, hamCopyTo, 2, 4); //Lấy 4 ký tự từ chuỗi chuoiCopyTo bắt đầu từ vị trí 0
                                                    //và sao chép vào mảng hamCopyTo bắt đầu từ vị trí 2
            Console.WriteLine(hamCopyTo);

            //Hàm bool EndsWith(string value)
            string fileNhac = "baihat.mp3";
            bool kiemTra = fileNhac.EndsWith(".mp3"); //".mp3" != ".mp3 "
            Console.WriteLine("File nhac co phai la mp3 khong? " + kiemTra);

            //Gán chuỗi theo string.Format
            int so = 14;
            string chuoiFormat = string.Format("n = {0} và can bac hai cua no la {1}", so, Math.Sqrt(so));
            Console.WriteLine(chuoiFormat);

            //Hàm Equals
            string chuoi6 = "Ha Ngoc Hung";
            string chuoi7 = "Ha Ngoc Hai";
            string chuoi8 = "Ha Ngoc Hung";
            Console.WriteLine(chuoi6.Equals(chuoi7));
            Console.WriteLine(chuoi6.Equals(chuoi8));

            //Chèn thêm vào chuỗi
            string chuoiCanChen = "Ha Ngoc Hung";
            string chuoiSeChen = "Dang hoc C#";
            //chèn chuỗi chuoiSeChen vào chuỗi chuoiCanChen tại vị trí 12
            string chuoiDaChen1 = chuoiCanChen.Insert(12, " " + chuoiSeChen);
            //chèn chuỗi chuoiSeChen vào chuỗi chuoiCanChen tại vị trí 6
            string chuoiDaChen2 = chuoiCanChen.Insert(6, " " + chuoiSeChen);
            Console.WriteLine(chuoiDaChen1);
            Console.WriteLine(chuoiDaChen2);
            Console.ReadKey();
        }
    }
}
