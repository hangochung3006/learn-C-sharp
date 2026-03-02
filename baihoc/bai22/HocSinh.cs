using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    internal class HocSinh
    {
        public int maHS { get; set; }
        public string tenHS { get; set; }
        public int tuoi { get; set; }

        public HocSinh() { }

        public HocSinh(int maHS, string tenHS, int tuoi)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.tuoi = tuoi;
        }

        public override string ToString()
        {
            return $"MaHS: {maHS}, TenHS: {tenHS}, Tuoi: {tuoi}";
        }
    }
}
