using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> func = l =>
            {
                int min = int.MaxValue;
                foreach (var item in list)
                {
                    if (item<min)
                    {
                        min = item;
                    }
                }
                return min;
            };

            Console.WriteLine(func(list));

            
        }
    }
}
