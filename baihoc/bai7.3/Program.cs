using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float chieuCao, canNang;
            double BMI;
            Console.WriteLine("Chieu cao (m): ");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Can nang: ");
            canNang = float.Parse(Console.ReadLine());
            BMI = canNang / Math.Pow(chieuCao, 2);
            Console.WriteLine("BMI cua ban la: " + BMI);
            if (BMI >= 35)
                Console.WriteLine("Than hinh qua beo!");
            else if (BMI >= 30 && BMI < 35)
                Console.WriteLine("Than hinh beo");
            else if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Than hinh hoi beo");
            else if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Than hinh binh thuong");
            else if (BMI >= 16 && BMI < 18.5)
                Console.WriteLine("Than hinh hoi gay");
            else if (BMI >= 15 && BMI < 16)
                Console.WriteLine("Than hinh gay");
            else
                Console.WriteLine("Than hinh qua gay");
            Console.ReadKey();
        }
    }
}
