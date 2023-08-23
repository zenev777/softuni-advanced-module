using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nAndM = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nAndM[0];
            int m = nAndM[1];

            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setN.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setM.Add(num);
            }

            if (setN.Count >= setM.Count)
            {
                foreach (var item in setN)
                {
                    if (setM.Contains(item))
                    {
                        Console.Write(item+" ");
                    }
                }
            }
            else
            {
                foreach (var item in setM)
                {
                    if (setN.Contains(item))
                    {
                        Console.Write(item + " ");
                    }
                }
            }

        }
    }
}
