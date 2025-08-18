using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo mảng 2 chiều
            int[,] arr = new int[3, 4];//Tạo ra mảng có 3 dòng, 4 cột

            //Khởi tạo và gán giá trị
            int[,] arr1 = new int[2, 3] { {1, 2, 3 }, {4, 5 ,6 } }; //Các phần tử phải có cùng kích thước

            //Khởi tạo mảng 2 chiều ngẫu nhiên
            Random r = new Random();
            int dong = 3;
            int cot = 4;
            int[,] arr2 = new int[dong, cot];
            for(int i = 0; i < dong; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    arr2[i, j] = r.Next(100);
                }
            }
            Console.WriteLine("arr2[0,2] = "+ arr2[0,2]);

            //Truy xuất phần tử qua Index
            int[,] arr3 = new int[2, 3] { { 1, 2, 3} , { 2, 4, 5} };
            for(int i = 0; i < arr3.GetLength(0); i++)
            {
                for(int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
