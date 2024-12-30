using AtCoder.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Atc
{
    // https://atcoder.jp/contests/atc001/tasks/dfs_a
    public class ATC001A
    {
        public static void Main(string[] args)
        {
            var writer = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(writer);

            // 整数配列の入力
            var hw = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long h = hw[0];
            long w = hw[1];
            var c = new char[h, w];
            long sh = 0;
            long sw = 0;
            long gh = 0;
            long gw = 0;

            // データの取得
            for (int i = 0; i < h; i++)
            {
                var line = Console.ReadLine();
                for (int j = 0; j < w; j++)
                {
                    c[i, j] = line[j];

                    // スタートとゴールの記録
                    switch (line[j])
                    {
                        case 's':
                            sh = i;
                            sw = j;
                            break;
                        case 'g':
                            gh = i;
                            gw = j;
                            break;
                    }
                }
            }

            bool result = DFS(c, sh, sw);

            Console.WriteLine(result ? "Yes" : "No");

            Console.Out.Flush();
        }
        static bool DFS(char[,] map, long h, long w)
        {
            if (h < 0 || h >= map.GetLength(0))
                return false;
            if (w < 0 || w >= map.GetLength(1))
                return false;

            switch (map[h, w])
            {
                // ゴールだったら
                case 'g':
                    // 探索終了
                    return true;

                // すでに通った道か壁だったら
                case 'd':
                case '#':
                    // 元の道に戻って探索再開
                    return false;

                // 開始位置か道だったら
                case 's':
                case '.':
                    // たどり着いたことを記録して
                    map[h, w] = 'd';

                    // 次の道へ探索する
                    return DFS(map, h + 1, w)
                        || DFS(map, h - 1, w)
                        || DFS(map, h, w + 1)
                        || DFS(map, h, w - 1);

                default:
                    throw new ArgumentException();
            }
        }
    }
}
