﻿using AtCoder.AtCoder.Abc;
using AtCoder.AtCoder.Arc;
using AtCoder.AtCoder.Atc;
using AtCoder.AtCoder.Joi;
using AtCoder.AtCoder.Keyence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Exec(args);
                Console.WriteLine("============ Retry ============");
                Console.Out.Flush();
            }
        }

        private static void Exec(string[] args)
        {
            ABC076C
                .Main(args);
        }

        public class Debug
        {
            public static void Log(string message)
            {
                Console.WriteLine("DEBUG: " + message);
            }
        }
    }
}
