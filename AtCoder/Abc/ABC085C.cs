using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC085C
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var n = inputLongArray[0];
            var y = inputLongArray[1];

            // 10000
            for (long i = n; i >= 0; i--)
            {
                // 5000
                for (long j = n - i; j >= 0; j--)
                {
                    // 1000
                    long k = n - i - j;

                    if (i * 10000 + j * 5000 + k * 1000 == y)
                    {
                        Console.WriteLine($"{i} {j} {k}");

                        Console.Out.Flush();
                        return;
                    }
                }
            }

            Console.WriteLine("-1 -1 -1");

            Console.Out.Flush();
        }
    }
}
