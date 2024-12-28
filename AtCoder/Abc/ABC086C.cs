using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC086C
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // t, x, y
            long[,] plan = new long[n, 3];
            long[] current = new long[3] { 0, 0, 0 };
            string result = "Yes";

            for (int i = 0; i < n; i++)
            {
                // 整数配列の入力
                var input = Console.ReadLine().Split(' ').Select(txt => long.Parse(txt)).ToArray();
                plan[i, 0] = input[0];
                plan[i, 1] = input[1];
                plan[i, 2] = input[2];
            }

            for (int i = 0; i < plan.GetLength(0); i++)
            {
                var distance = Math.Abs(plan[i, 1] - current[1]) + Math.Abs(plan[i, 2] - current[2]);
                var moveTime = Math.Abs(plan[i, 0] - current[0]);

                if (distance > moveTime)
                {
                    result = "No";
                    break;
                }
                else if (distance == moveTime)
                {
                    current[0] = plan[i, 0];
                    current[1] = plan[i, 1];
                    current[2] = plan[i, 2];
                    continue;
                }
                else
                {
                    if ((moveTime - distance) % 2 == 1)
                    {
                        result = "No";
                        break;
                    }

                    current[0] = plan[i, 0];
                    current[1] = plan[i, 1];
                    current[2] = plan[i, 2];
                    continue;
                }
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
