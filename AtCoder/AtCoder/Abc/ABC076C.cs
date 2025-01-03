using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.AtCoder.Abc
{
    // https://atcoder.jp/contests/abc076/tasks/abc076_c
    public class ABC076C
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            var s = new StringBuilder(Console.ReadLine());
            string t = Console.ReadLine();

            if (s.Length < t.Length)
            {
                Console.WriteLine("UNRESTORABLE");
                return;
            }

            int matchIndex = int.MinValue;

            // tの文字数を考慮してsの一番後ろから探索する
            for (int i = s.Length - t.Length; 0 <= i; i--)
            {
                bool mismatch = false;

                // tの文字を順番に比較して、一致しない場所があるかを確認
                for (int j = 0; j < t.Length; j++)
                {
                    if (s[i + j] != '?' && s[i + j] != t[j])
                    {
                        mismatch = true;
                        break;
                    }
                }


                // すべて一致しているのであればインデックスを記録
                if (!mismatch)
                {
                    matchIndex = i;
                    break;
                }
            }

            // インデックスが初期値ならば復元不可とする
            if (matchIndex == int.MinValue)
            {
                Console.WriteLine("UNRESTORABLE");
                return;
            }

            // 文字列を復元
            char[] answer = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                // 一致していればtの文字を使用
                if (matchIndex <= i && i <= matchIndex + t.Length - 1)
                {
                    answer[i] = t[i - matchIndex];
                }
                // ?であればaを使用
                else if (s[i] == '?')
                {
                    answer[i] = 'a';
                }
                else
                {
                    answer[i] = s[i];
                }
            }

            Console.WriteLine(string.Join("", answer));



            Console.Out.Flush();
        }
    }
}
