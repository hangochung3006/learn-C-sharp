using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bai22
{
    internal class SinhVien
    {
        #region biến lớp
        private int maSV;
        private string tenSV;
        private int tuoi;
        private string lop;
        private float diemThi;
        #endregion
        //Gán giá trị mặc định cho đối tượng
        #region Constructor
        public SinhVien()
        {
            this.maSV = 1;
            this.tenSV = "Ha Ngoc Hung";
            this.tuoi = 25;
            this.lop = "CNTT1";
            this.diemThi = 7;
        }
        //Khởi tạo giá trị cho đối tượng do người dùng truyền vào
        public SinhVien(int maSV, string tenSV, int tuoi, string lop, float diemThi)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.tuoi = tuoi;
            this.lop = lop;
            this.diemThi = diemThi;
        }
        #endregion
        //Khai báo Properties để có thể truy xuất dữ liệu
        #region Properties
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public float DiemThi
        {
            get { return diemThi; }
            set { diemThi = value; }
        }
        #endregion
        //Phương thức ToString 
        public override string ToString()
        {
            return this.MaSV + "\t" + this.TenSV;
        }
        //Suppor method
        private bool checkDiemThi()
        {
            return (this.diemThi >= 0 && this.diemThi <= 10);
        }
        //Service method
        public void xuatThongTin()
        {
            Console.WriteLine("Ma SV: " + this.MaSV);
            Console.WriteLine("Ten SV: " + this.TenSV);
            Console.WriteLine("Tuoi: " + this.Tuoi);
            Console.WriteLine("Lop: " + this.Lop);
            if (checkDiemThi())
            {
                Console.WriteLine("Diem thi: " + this.DiemThi);
            }
            else
            {
                Console.WriteLine("Diem thi khong hop le!");
            }
        }
        //Overloading method
        public int Tong (int a, int b)
        {
            return a + b;
        }
        public int Tong(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public double Tong(double a, double b)
        {
            return a + b;
        }
    }
}
