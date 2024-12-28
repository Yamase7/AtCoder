using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ABC081A
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string str = Console.ReadLine();

            long count = 0;

            foreach (var s in str)
            {
                if (s == '1')
                {
                    count++;
                }
            }


            string result = $"{count}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
