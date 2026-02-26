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
        private int maSV;
        private string tenSV;
        private int tuoi;
        private string lop;

        //Gán giá trị mặc định cho đối tượng
        public SinhVien()
        {
            this.maSV = 1;
            this.tenSV = "Ha Ngoc Hung";
            this.tuoi = 25;
            this.lop = "CNTT1";
        }
        //Khởi tạo giá trị cho đối tượng do người dùng truyền vào
        //public SinhVien(int maSV, string tenSV, int tuoi, string lop)
        //{
        //    this.maSV = maSV;
        //    this.tenSV = tenSV;
        //    this.tuoi = tuoi;
        //    this.lop = lop;
        //}

        //Khai báo Properties để có thể truy xuất dữ liệu
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

    }
}
