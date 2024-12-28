using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC049C
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = new string(Console.ReadLine().Reverse().ToArray());
            string t = string.Empty;
            string[] words = new string[4]
            {
                "dream",
                "dreamer",
                "erase",
                "eraser",
            };

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }

            var isWrong = false;
            for (int i = 0; i < s.Length;)
            {
                var sameWord = false;
                for (int j = 0; j < 4; j++)
                {
                    string word = words[j];

                    if (i + word.Length > s.Length)
                    {
                        continue;
                    }

                    if (s.Substring(i, word.Length) == word)
                    {
                        sameWord = true;
                        i += word.Length;
                    }
                }

                if (!sameWord)
                {
                    isWrong = true;
                    break;
                }
            }

            Console.WriteLine(!isWrong ? "YES" : "NO");
            Console.Out.Flush();
        }
    }
}
