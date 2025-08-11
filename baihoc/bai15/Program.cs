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

            //IndexOf
            string chuoi9 = "HaNgocHung";
            int indexOf = chuoi9.IndexOf("o"); //Tìm kiếm ký tự 'o' đầu tiên trong chuỗi
            int indexOf2 = chuoi9.IndexOf("o", 5); //Tìm kiếm ký tự 'o' bắt đầu từ vị trí 5
            Console.WriteLine(indexOf);
            Console.WriteLine(indexOf2);

            //LastIndexOf
            string chuoi10 = "HaNgocHung";
            int lastIndexOf = chuoi10.LastIndexOf("H"); //Tìm kiếm ký tự 'H' cuối cùng trong chuỗi
            int lastIndexOf2 = chuoi10.LastIndexOf("h"); //Tìm kiếm ký tự 'h' cuối cùng trong chuỗi
            Console.WriteLine(lastIndexOf);
            Console.WriteLine(lastIndexOf2);

            //Remove(index,count)
            string chuoi11 = "HaNgocHung";
            string chuoiDaXoa = chuoi11.Remove(2, 3); //Xóa 3 ký tự bắt đầu từ vị trí 2
            Console.WriteLine(chuoi11);
            Console.WriteLine(chuoiDaXoa);

            //Replace("str old", "str new")
            string chuoi12 = "Ha Ngoc Hung";
            string chuoiDaThayThe = chuoi12.Replace(" ", "");
            Console.WriteLine(chuoi12);
            Console.WriteLine(chuoiDaThayThe);

            //StartsWith
            string chuoi13 = "HaNgocHung";
            bool chuoiBatDau = chuoi13.StartsWith("Ha");
            Console.WriteLine(chuoiBatDau);

            //Substring
            string chuoi14 = "HaNgocHung";
            string chuoiCat = chuoi14.Substring(2, 4); //Lấy 4 ký tự bắt đầu từ vị trí index 2
            Console.WriteLine(chuoiCat);

            //ToLower() ToUpper()
            string chuoi15 = "HaNgocHung";
            string chuoiVietHoa = chuoi15.ToUpper();
            string chuoiVietThuong = chuoi15.ToLower();
            Console.WriteLine(chuoiVietHoa);
            Console.WriteLine(chuoiVietThuong);

            //Trim(), TrimEnd(), TrimStart()
            string chuoi16 = "   Ha Ngoc Hung    ";
            string chuoiTrim = chuoi16.Trim();
            string chuoiTrimEnd = chuoi16.TrimEnd();
            string chuoiTrimStart = chuoi16.TrimStart();
            Console.WriteLine(chuoiTrim);
            Console.WriteLine(chuoiTrimEnd);
            Console.WriteLine(chuoiTrimStart);

            //Split
            string chuoi17 = "Ha,Ngoc,Hung";
            string[] chuoiSplit = chuoi17.Split(',');
            Console.WriteLine(chuoiSplit[0]);
            Console.WriteLine(chuoiSplit[1]);
            Console.WriteLine(chuoiSplit[2]);

            //Join string
            string[] chuoiCanGhep = new string[3]; //Khởi tạo 1 mảng có 3 phần tử, các phần tử có kiểu string
            chuoiCanGhep[0] = "Ha";
            chuoiCanGhep[1] = "Ngoc";
            chuoiCanGhep[2] = "Hung";
            string chuoiDaGhep = string.Join(",", chuoiCanGhep);
            Console.WriteLine(chuoiDaGhep);
            Console.ReadKey();
        }
    }
}
