using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.TDPC
{
    /// <summary>
    /// 部分和 DP
    /// https://atcoder.jp/contests/tdpc/tasks/tdpc_contest
    /// </summary>
    public class TDPCA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var p = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            var m = 10000;
            var dp = new bool[n + 1, m + 1];

            // 初期値（0問解いた場合は必ず0点が1パターンのみ）
            dp[0, 0] = true;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    dp[i, j] = dp[i - 1, j];

                    if (j >= p[i - 1])
                    {
                        dp[i, j] |= dp[i - 1, j - p[i - 1]];
                    }
                }
            }

            var count = 0;
            for (int i = 0; i <= m; i++)
            {
                if (dp[n, i])
                    count++;
            }


            string result = $"{count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
