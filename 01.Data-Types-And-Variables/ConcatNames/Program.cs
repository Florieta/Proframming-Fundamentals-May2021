﻿using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string result = firstName + delimiter + secondName;
            Console.WriteLine(result);

        }
    }
}
