﻿using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = numbers.OrderByDescending(n => n).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
