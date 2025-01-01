using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc104/tasks/abc007_c
    public class ABC007C
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var work = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            var r = work[0];
            var c = work[1];

            work = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            (long x, long y) s = (work[1], work[0]);

            work = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            (long x, long y) g = (work[1], work[0]);

            // マップの取得
            var map = new char[r, c];
            var counter = new long[r, c];
            for (int i = 0; i < r; i++)
            {
                string data = Console.ReadLine();
                for (int j = 0; j < data.Length; j++)
                {
                    map[i, j] = data[j];
                }
            }

            var queue = new Queue<(long x, long y)>();

            // 開始地点を登録
            queue.Enqueue((s.x-1, s.y-1));
            map[s.y - 1, s.x - 1] = 'o';
            counter[s.y - 1, s.x - 1] = 0;

            // 次に移動する座標の計算用配列
            var d = new (long x, long y)[]
            {
                (1, 0),
                (0, 1),
                (-1, 0),
                (0, -1),
            };

            bool outOfMap(long x, long y) => x < 0 || x >= c || y < 0 || y >= r;
            bool isWall(long x, long y) => map[y, x] == '#';
            bool isChecked(long x, long y) => map[y, x] == 'x' || map[y, x] == 'o';

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                // 現在地を通過済みとして記録
                map[current.y, current.x] = 'x';

                // 現在地の四方を確認する
                for (int i = 0; i < 4; i++)
                {
                    // 確認先座標
                    (long x, long y) newXY = (current.x + d[i].x, current.y + d[i].y);

                    // 確認先がマップ外だったらスキップ
                    if (outOfMap(newXY.x, newXY.y))
                        continue;

                    // 確認先が壁/予約/通過済みであればスキップ
                    if (isWall(newXY.x, newXY.y) || isChecked(newXY.x, newXY.y))
                        continue;

                    // 確認先を通過予定とし歩数を記録する
                    map[newXY.y, newXY.x] = 'o';
                    queue.Enqueue(newXY);
                    counter[newXY.y, newXY.x] = counter[current.y, current.x] + 1;
                }
            }

            string result = $"answer: {counter[g.y-1, g.x-1]}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
