﻿using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> Knights =NewMethod;
           
            Knights(names);
        }



        private static void NewMethod(string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}
