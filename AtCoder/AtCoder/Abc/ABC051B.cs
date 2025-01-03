using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtCoder.AtCoder.Abc
{
    // https://atcoder.jp/contests/abc051/tasks/abc051_b
    public class ABC051B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long k = inputLongArray[0];
            long s = inputLongArray[1];

            long count = 0;

            for (long x = 0; x <= k; ++x)
            {
                for (long y = 0; y <= k; ++y)
                {
                    long z = s - x - y;

                    if (0 <= z && z <= k)
                    {
                        count++;
                    }
                }
            }

            string result = $"{count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
