using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Khai báo Dic
            Dictionary<int, string> dic = new Dictionary<int, string>();

            //2. Khai báo Dic có gán giá trị
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { {1, "Hưng"}, {2, "Huyền"} };

            //3. Add
            Dictionary<int, string> dic3 = new Dictionary<int, string>() { { 1, "Hung" }, { 2, "Huyen" } };
            dic3.Add(3, "Mimi");
            dic3.Add(4, "SamSam");
            foreach(KeyValuePair<int,string> pTu in dic3)
            {
                Console.WriteLine(pTu);
            }

            //4. Duyệt dic
            Dictionary<int, string> dic4 = new Dictionary<int, string>() { { 1, "Hung" }, { 2, "Huyen" } };
            foreach (KeyValuePair<int, string> pTu in dic4)
            {
                Console.WriteLine(pTu);
                Console.WriteLine("Key: {0}, Value: {1}", pTu.Key, pTu.Value);
            }

            //5. .ContainsKey()
            Dictionary<int, string> dic5 = new Dictionary<int, string>() { { 1, "Hung" }, { 2, "Huyen" } };
            bool result = dic5.ContainsKey(1);
            bool result1 = dic5.ContainsKey(3);
            Console.WriteLine("ket qua 1 = " + result);
            Console.WriteLine("ket qua 2 = " + result1);








            Console.ReadKey();
        }
    }
}
