using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC088B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var cards = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            Array.Sort(cards);
            Array.Reverse(cards);

            long alice = 0;
            long bob = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    alice += cards[i];
                }
                else
                {
                    bob += cards[i];
                }
            }

            string result = $"{alice - bob}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
