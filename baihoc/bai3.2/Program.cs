using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 5;
            int i3 = -3;
            float d1 = 2f;
            float d2 = 5f;
            float d3 = -0.5f;
            float resultA = i1 + (i2 * i3);
            float resultB = i1 * (i2 + i3);
            float resultC = (float)i1 / (i2 + i3);
            float resultE = (float)i1 / i2 + i3;
            float resultK = d1 + (d2 * d3);
            float resultL = d1 + d2 * d3;
            float resultM = d1 / d2 - d3;
            float resultN = d1 + (d2 - d3);
            float resultO = d1 + d2 + d3 / 3;
            float resultP = (d1 + d2 + d3) / 3;
            float resultQ = d1 + d2 + (d3 / 3);
            float resultR = 3 * (d1 + d2) * (d1 - d3);
            Console.WriteLine("{0} + ({1} * {2}) = {3}", i1, i2, i3, resultA); //a
            Console.WriteLine("{0} * ({1} + {2}) = {3}", i1, i2, i3, resultB); //b
            Console.WriteLine("{0} / ({1} + {2}) = {3}", i1, i2, i3, resultC); //c
            Console.WriteLine("{0} / {1} + {2} = {3}", i1, i2, i3, resultE); //e
            Console.WriteLine("{0} + ({1} * {2}) = {3}", d1, d2, d3, resultK); //k
            Console.WriteLine("{0} + {1} * {2} = {3}", d1, d2, d3, resultL); //l
            Console.WriteLine("{0} / {1} - {2} = {3}", d1, d2, d3, resultM); //m
            Console.WriteLine("{0} + ({1} - {2}) = {3}", d1, d2, d3, resultN); //n
            Console.WriteLine("{0} + {1} + {2} / 3 = {3}", d1, d2, d3, resultO); //o
            Console.WriteLine("({0} + {1} + {2}) / 3 = {3}", d1, d2, d3, resultP); //p
            Console.WriteLine("{0} + {1} + ({2} / 3) = {3}", d1, d2, d3, resultQ); //q
            Console.WriteLine("3 * ({0} + {1}) * ({0} - {2}) = {3}", d1, d2, d3, resultR); //r
            Console.ReadLine();
        }
    }
}
