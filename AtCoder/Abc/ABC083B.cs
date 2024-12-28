using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC083B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var nums = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            var n = nums[0];
            var a = nums[1];
            var b = nums[2];

            long allSum = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = i;
                var sum = 0;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (sum >= a && sum <= b)
                {
                    allSum += i;
                }
            }


            string result = $"{allSum}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
