using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!map.ContainsKey(number))
                {
                    map[number] = 0;
                }                
                map[number]++;
            }

            foreach (var item in map)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
            
        }
    }
}
