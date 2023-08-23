using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> map =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string color = input[0];


                string[] clothes = input[1].Split(",");

                if (!map.ContainsKey(color))
                {
                    map[color] = new Dictionary<string, int>();
                    
                    for (int j = 0;  j < clothes.Length;  j++)
                    {
                        map[color].Add(clothes[j], 0);
                    }
                    
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    map[color][clothes[j]]++;
                }

            }
        }
    }
}
