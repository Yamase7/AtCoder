using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Lib
{
    public static class Search
    {
        // 目的地にたどり着けるかどうか
        public static bool DFS(char[,] map, long h, long w)
        {
            if (h < 0 || h >= map.GetLength(0))
                return false;
            if (w < 0  || w >= map.GetLength(1))
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

        public static void BitSearch(string s)
        {
            int n = s.Length - 1;
            for (int bit = 0; bit < 1 << n; bit++)
            {

            }
        }
    }
}
