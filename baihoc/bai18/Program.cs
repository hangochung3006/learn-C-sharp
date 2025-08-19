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

            //GetRange(int index, int count)
            List<int> list3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> danhSachGetRange = list3.GetRange(1, 3);
            foreach (int item in danhSachGetRange)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //IndexOf(<value>)
            List<int> list4 = new List<int>() { 77, 48, 53, 54, 21 };
            Console.WriteLine(list4.IndexOf(6));
            Console.WriteLine(list4.IndexOf(54));

            //Insert(int index, value)
            List<int> list5 = new List<int>() { 1, 8, 2, 4, 5 };
            list5.Insert(1, 2);
            foreach(int item in list5)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //InsertRange (int index, <Danh_sách_chèn_thêm>)
            List<int> list6 = new List<int>() { 1, 8, 2, 4, 5 };
            List<int> list7 = new List<int>() { 5, 2, 1 };
            list6.InsertRange(2, list7);
            foreach(int item in list6)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //RemoveAt(int index)
            List<int> list8 = new List<int>() { 1, 8, 2, 4, 5 };
            list8.RemoveAt(1);
            foreach(int item in list8)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //RemoveRange(int index, int count)
            List<int> list9 = new List<int>() { 1, 8, 2, 4, 5 };
            list9.RemoveRange(2, 3);
            foreach (int item in list9)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Reverse()

            //Sort()

            //BinarySearch

            //Max, min

























            Console.ReadKey();
        }
    }
}
