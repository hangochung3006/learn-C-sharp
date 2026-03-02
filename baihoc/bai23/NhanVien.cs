using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai23
{
    internal class NhanVien
    {
        //Khởi tạo
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public int Luong { get; set; }

        public override string ToString()
        {
            return $"{MaNV}    {TenNV}    {Luong}";
        }
    }
}
