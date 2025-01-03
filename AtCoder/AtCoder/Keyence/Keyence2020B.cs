using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.AtCoder.Keyence
{
    // https://atcoder.jp/contests/keyence2020/tasks/keyence2020_b
    public class Keyence2020B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // データの入力
            long n = long.Parse(Console.ReadLine());
            var robots = new (long x, long l)[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(str => long.Parse(str)).ToArray();
                robots[i] =(input[0], input[1]);
            }

            long counter = 0;

            // 右腕の先端の位置でソートする
            (long left, long right)[] sortedByT = robots
                .Select(robot => (robot.x - robot.l, robot.x + robot.l))
                .OrderBy(robot => robot.Item2).ToArray();

            // 現在地を最低値にする
            long current = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                // 現在位置が次のロボットの左手と重ならなかったら
                if (current <= sortedByT[i].left)
                {
                    // カウントアップ
                    counter++;

                    // ロボットの右手位置を現在地として記録する
                    current = sortedByT[i].right;
                }
            }

            string result = $"{counter}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
