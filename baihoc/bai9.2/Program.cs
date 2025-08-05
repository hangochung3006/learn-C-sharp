using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bam muon lua chon tim kiem theo ten, tac gia, tieu de, hay nha xuat ban");
            string a = Console.ReadLine();
            switch (a)
            {
                case "ten":
                    Console.WriteLine("Nhap ten ma ban muon tim");
                    break;
                case "tac gia":
                    Console.WriteLine("Nhap tac gia ma ban muon tim");
                    break;
                case "tieu de":
                    Console.WriteLine("Nhap tieu de ma ban muon tim");
                    break;
                case "nha xuat ban":
                    Console.WriteLine("Nhap nha xuat ban ma ban muon tim");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
