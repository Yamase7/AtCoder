using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.AtCoder.Joi
{
    // https://atcoder.jp/contests/joi2008yo/tasks/joi2008yo_a
    public class JOI2007A
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            var change = 1000 - n;
            var count = 0;

            int[] coins = new int[6] { 500, 100, 50, 10, 5, 1 };

            // 全硬貨確認する
            foreach (var coin in coins)
            {
                // その硬貨をおつりとして出す
                while (change >= coin)
                {
                    count++;
                    change -= coin;
                }
            }

            string result = $"{count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
