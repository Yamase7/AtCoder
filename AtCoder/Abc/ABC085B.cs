using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC085B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            long n = long.Parse(Console.ReadLine());
            long[] nums = new long[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }

            var numList = new List<long>();

            foreach (var num in nums)
            {
                if (!numList.Contains(num))
                {
                    numList.Add(num);
                }
            }

            string result = $"{numList.Count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
