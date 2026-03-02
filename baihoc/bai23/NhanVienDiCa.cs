using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai23
{
    internal class NhanVienDiCa : NhanVien
    {
        public string CaLam { get; set; }

        public override string ToString()
        {
            return $"{MaNV}     {TenNV}     {Luong}     {CaLam}"; 
        }
    }
}
