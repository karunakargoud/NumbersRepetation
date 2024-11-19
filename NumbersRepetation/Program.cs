using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersRepetation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers:");
            int[] arr = { 1, 2, 3, 2, 3, 1, 3 };

            Dictionary<int,int> dic = new Dictionary<int,int>();
            foreach(var k in arr)
            {
                if (dic.ContainsKey(k))
                {
                    dic[k]++;
                }
                else
                {
                    dic[k] = 1;
                }
            }
            foreach (var k in dic)
            {
                Console.WriteLine(k.Key +"-"+k.Value);
            }
        }
    }
}
