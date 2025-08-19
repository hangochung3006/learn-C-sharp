using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo List
            List<int> danhSachSo = new List<int>();

            //Khởi tạo List có sẵn phần tử
            List<string> danhSachHoTen = new List<string>() { "Hưng", "Huyền", "Mimi" };

            //Add
            List<int> danhSachAdd = new List<int>();
            danhSachAdd.Add(1);
            danhSachAdd.Add(5);
            danhSachAdd.Add(10);
            foreach (int item in danhSachAdd)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Remove
            List<int> danhSachRemove = new List<int>() { 7, 7, 7, 8, 8, 8, 9 };
            foreach (int item in danhSachRemove)
            {
                Console.Write(item + " ");
            }
            danhSachRemove.Remove(7);
            danhSachRemove.Remove(8);
            Console.WriteLine("\nDanh sach sau khi remove");
            foreach (int item in danhSachRemove)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Count
            List<int> danhSachCount = new List<int>() { 1, 2, 3, 4, 7, 8, 4, 2, 3 };
            Console.WriteLine(danhSachCount.Count());

            //Clear
            List<int> danhSachClear = new List<int>() { 1, 2, 3, 4, 7, 8, 4, 2, 3 };
            danhSachClear.Clear();
            Console.WriteLine(danhSachClear.Count());

            //AddRange
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = new List<int>() { 4, 5 };
            list1.AddRange(list2);
            foreach(int item in list1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //bool <Tên_biến< = <Danh_sách>.Contains(<value>)
            List<int> danhSachCheck = new List<int>() { 1, 2, 3 };
            bool check = danhSachCheck.Contains(4);
            Console.WriteLine(check);




            Console.ReadKey();
        }
    }
}
