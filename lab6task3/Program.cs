﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionCache<int, string> cache = new FunctionCache<int, string>(ExpensiveFunction);

            string result1 = cache.GetResult(5, TimeSpan.FromSeconds(10));
            Console.WriteLine(result1);

            System.Threading.Thread.Sleep(5000);

            string result2 = cache.GetResult(5, TimeSpan.FromSeconds(10));
            Console.WriteLine(result2);
        }

        static string ExpensiveFunction(int key)
        {
            Console.WriteLine("Executing expensive function...");
            return $"Result for key {key}";
        }
    }
}

