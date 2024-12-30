using AtCoder.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc175/tasks/abc175_b
    public class ABC175B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var l = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long count = 0;
            // 昇順にソートする
            Sort.QuickSort(l, 0, l.Length - 1);

            for (int i = 0; i < l.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        // 値が重複していたらスキップ
                        if (l[i] != l[j] && l[j] != l[k] && l[k] + l[j] > l[i])
                        {
                            count++;
                        }
                    }
                }
            }

            string result = $"{count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
