using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'a'; //97
            char ch2 = 'b'; //98
            char ch3 = 'a'; //97
            char ch4 = 'm'; //109
            //CompareTo
            Console.WriteLine(ch1.CompareTo(ch2)); //so sánh ch1 với ch2
            Console.WriteLine(ch2.CompareTo(ch1)); //so sánh ch2 với ch1
            Console.WriteLine(ch1.CompareTo(ch3)); //so sánh ch1 với ch3
            Console.WriteLine(ch1.CompareTo(ch4)); //so sánh ch1 với ch4
            //Equals
            Console.WriteLine(ch1.Equals(ch2)); //so sánh ch1 với ch2
            Console.WriteLine(ch1.Equals(ch3)); //so sánh ch1 với ch3
        }
    }
}
