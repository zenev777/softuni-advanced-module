using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int raws = dim[0];
            int cols = dim[1];
            int[,] matrix = new int[raws, cols];
            int maxSum = int.MinValue;
            int start = 0;
            int end = 0;
            for (int i = 0; i < raws; i++)
            {
                int [] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = number[j];
                }
            }

            for (int i = 0; i < raws-2; i++)
            {
                for (int j = 0; j < cols-2; j++)
                {
                    int sum = matrix[i, j] + matrix[i,j+1] + matrix[i,j+2]+
                        matrix[i+1, j] + matrix[i+1, j + 1] + matrix[i+1, j + 2]+
                        matrix[i+2, j] + matrix[i+2, j + 1] + matrix[i+2, j + 2];
                    
                    if (sum>maxSum)
                    {
                        start=i;
                        end=j;
                        maxSum=sum;
                    }
                }
            }

            for (int i = start; i < start+3; i++)
            {
                for (int j = end; j < end + 3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
