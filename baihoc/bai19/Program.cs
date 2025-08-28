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

            //6. .ContainsValue()
            Dictionary<int, string> dic6 = new Dictionary<int, string>() { { 1, "Hung" }, { 2, "Huyen" } };
            bool result2 = dic6.ContainsValue("Hung");
            bool result3 = dic6.ContainsValue("Mimi");
            Console.WriteLine("ket qua 1 = " + result2);
            Console.WriteLine("ket qua 2 = " + result3);

            //7. <dic>[key]
            Dictionary<int, string> dic7 = new Dictionary<int, string>() { { 1, "Hung" }, { 2, "Huyen" } };
            string aGetValue = dic7[1];
            Console.WriteLine(aGetValue);

            //8. .Remove(key)
            Dictionary<int, string> dic8 = new Dictionary<int, string>() { { 1, "Hung" }, { 2, "Huyen" } };
            dic8.Remove(1);
            foreach(KeyValuePair<int,string> pTu in dic8)
            {
                Console.WriteLine(pTu);
            }

            //9. .Clear()
            Dictionary<int, string> dic9 = new Dictionary<int, string>() { { 1, "Hung" }, { 2, "Huyen" } };
            dic9.Clear();
            Console.WriteLine(dic9.Count());





















            Console.ReadKey();
        }
    }
}
