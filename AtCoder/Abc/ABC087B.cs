using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC087B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long x = long.Parse(Console.ReadLine());

            long count = 0;

            for (int ai = 0; ai <= a; ai++)
            {
                for (int bi = 0; bi <= b; bi++)
                {
                    for (int ci = 0; ci <= c; ci++)
                    {
                        if (x == 500 * ai + 100 * bi + 50 * ci)
                        {
                            count++;
                        }
                    }
                }
            }


            string result = $"{count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
