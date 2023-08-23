using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(String.Join(" ", number.Where(x => x % n != 0).Reverse()));
            
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int[], List<int>> func = l =>
            {
                List<int> lis = new List<int>();
                for (int i = number.Length-1; i >= 0; i--)
                {                 
                    lis.Add(number[i]);
                }
                return lis;
            };
            
            List<int> newList = func(number);

            Console.WriteLine(String.Join(" ", newList.Where(x=>x%n!=0)));

            
        }
    }
}
