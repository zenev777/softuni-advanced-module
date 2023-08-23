using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Action<int[]> action = numbers =>
            {
                switch (command)
                {
                    case "add":
                        for (int i = 0; i < nums.Length; i++)
                        {
                            nums[i]++;
                        }
                        break;

                    case "multiply":
                        for (int i = 0; i < nums.Length; i++)
                        {
                            nums[i] *= 2;
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < nums.Length; i++)
                        {
                            nums[i] -= 1;
                        }
                        break;
                    case "print":
                        Console.WriteLine(String.Join(" ", nums));
                        break;
                };

            };

            while (command!="end")
            {
                action(nums);
                command = Console.ReadLine();
            }
        }
    }
}
