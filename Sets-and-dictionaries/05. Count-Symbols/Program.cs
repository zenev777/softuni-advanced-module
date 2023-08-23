using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            SortedDictionary<char, int> map = new SortedDictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                
                if (!map.ContainsKey(str[i]))
                {
                    map[str[i]] = 0;
                }
                map[str[i]]++;
            }
           

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
