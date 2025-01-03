using AtCoder.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.AtCoder.Arc
{
    //https://atcoder.jp/contests/arc061/tasks/arc061_a
    public class ARC061A
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = Console.ReadLine();
            
            int n = s.Length - 1;
            long ans = 0;
            for (int bit = 0; bit < (1 << n); bit++)
            {
                List<int> plusPos = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if ((bit & (1 << j)) != 0) plusPos.Add(j);
                }
                CalcTotal(plusPos);
            }
            Console.WriteLine(ans);


            void CalcTotal(List<int> plusPos)
            {
                List<char> ss = new List<char>(s);
                for (int i = 0; i < plusPos.Count; i++)
                {
                    int insertPos = plusPos[i] + 1 + i;
                    ss.Insert(insertPos, '+');
                }
                string num = string.Concat(ss);
                ans += num.Split('+').Select(x => long.Parse(x)).Sum();
            }

            string result = $"{ans}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
