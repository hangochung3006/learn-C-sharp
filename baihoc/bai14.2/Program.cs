using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Char.IsDigit('1'));
            Console.WriteLine(Char.IsLetter('a'));
            Console.WriteLine(Char.IsWhiteSpace(' '));
            Console.WriteLine(Char.IsLower('a'));
            Console.WriteLine(Char.IsUpper('A'));
            Console.WriteLine(Char.ToLower('A'));
            Console.WriteLine(Char.ToUpper('a'));
        }
    }
}
