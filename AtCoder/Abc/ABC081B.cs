using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC081B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var nums = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long count = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    break;
                }

                if (i == n - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        nums[j] /= 2;
                    }

                    count++;
                    i = -1;
                    continue;
                }
            }

            string result = $"{count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
