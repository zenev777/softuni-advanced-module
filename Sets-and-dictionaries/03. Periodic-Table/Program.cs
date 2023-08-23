using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] chemichals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < chemichals.Length; j++)
                {
                    set.Add(chemichals[j]);
                }
            }
            
            Console.WriteLine(String.Join(" ", set));
        }
    }
}
