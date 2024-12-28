using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class PracticeA
    {
        public static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            var bc = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            string s = Console.ReadLine();
            var b = bc[0];
            var c = bc[1];

            string result = $"{a + b + c} {s}";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
