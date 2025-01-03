using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.AOJ
{
    /// <summary>
    /// DP ナップサック問題
    /// https://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=DPL_1_B&lang=jp
    /// </summary>
    public class DPL1B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // データの入力
            var input = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long n = input[0], w = input[1];
            var goods = new (long v, long w)[n];
            for (int i = 0; i < n; i++)
            {
                var input2 = Console.ReadLine().Split(' ').Select(str => long.Parse(str)).ToArray();
                goods[i] = (input2[0], input2[1]);
            }

            var dp = new long[n + 1, w + 1];

            // dpの初期値をセット（何も選ばなかったら価値は0）
            for (int i = 0; i <= w; i++)
            {
                dp[0, i] = 0;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= w; j++)
                {
                    dp[i, j] = goods[i - 1].w <= j  // 対象の品物がj以内の重さであれば
                        ? Math.Max( // 選択可能なので選択するかを確認
                            dp[i - 1, j - goods[i - 1].w] + goods[i - 1].v,  // 対象の品物の重さを引いた重さの最大価値と足した値
                            dp[i - 1, j]) // 前回の最大価値を使用
                        : dp[i - 1, j]; // そもそも選択できないので前回の最大価値を使用

                }
            }

            string result = $"{dp[n, w]}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
