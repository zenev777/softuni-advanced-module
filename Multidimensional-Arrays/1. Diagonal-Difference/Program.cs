using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = numbers[j];
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i, i];
                sum2 += matrix[i, n-1-i];
            }
            Console.WriteLine(Math.Abs(sum1-sum2));
        }
    }
}
