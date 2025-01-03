using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.AtCoder.Arc
{
    // https://atcoder.jp/contests/arc004/tasks/arc004_1
    public class ARC004A
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            var positions = new long[n, 2];

            for (int i = 0; i < n; i++)
            {
                // 整数配列の入力
                var xy = Console.ReadLine().Split(' ').Select(str => long.Parse(str)).ToArray();

                positions[i, 0] = xy[0];
                positions[i, 1] = xy[1];
            }

            double max = 0.0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var width = positions[j, 0] - positions[i, 0];
                    var height = positions[j, 1] - positions[i, 1];
                    var distance = Math.Abs(
                        Math.Sqrt(
                            (width * width) + (height * height)));

                    if (distance > max)
                    {
                        max = distance;
                    }
                }
            }

            string result = $"{max}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
