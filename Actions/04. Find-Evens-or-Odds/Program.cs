using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = input[0];
            int end = input[1];
            string word = Console.ReadLine();

            
            Func<int, int, List<int>> GenNums = (start, end) =>
            {
                List<int> numbers = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    numbers.Add(i);
                }

                return numbers;
            };

            List<int> numbers = GenNums(start, end);


            Predicate<int> even = x => { return x % 2 == 0; };
            Predicate<int> odd = x => { return x % 2 != 0; };

            List<int> res = new List<int>();
            if (word == "odd")
            {
                res=numbers.FindAll(odd);

            }
            else if (word == "even")
            {
                res=numbers.FindAll(even);
            }

            Console.WriteLine(String.Join(" ", res));
          
        }
    }
}
