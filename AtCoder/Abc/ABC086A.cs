using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    public class ABC086A
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var ab = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var a = ab[0];
            var b = ab[1];


            string result = (a * b) % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
