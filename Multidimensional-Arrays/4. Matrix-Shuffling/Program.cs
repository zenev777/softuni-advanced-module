using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dim = Console.ReadLine().Split().ToArray();
            int raws = int.Parse(dim[0]);
            int cols = int.Parse(dim[1]);
            string[,] matrix = new string[raws, cols];

            for (int i = 0; i < raws; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = parameters[j];
                }
            }

            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] commands = input.Split();

                if (isValide(commands,raws,cols))
                {
                    string Temp = matrix[int.Parse(commands[1]), int.Parse(commands[2])];
                    matrix[int.Parse(commands[1]), int.Parse(commands[2])]=matrix[int.Parse(commands[3]), int.Parse(commands[4])];
                    matrix[int.Parse(commands[3]), int.Parse(commands[4])] = Temp;

                    matrixPr(raws,cols,matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
        static bool isValide(string[] commands, int raws, int cols)
        {
            return
                commands[0] == "swap"
                &&
                int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < raws
                &&
                int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < cols
                &&
                int.Parse(commands[3]) >= 0 && int.Parse(commands[3]) < raws
                &&
                int.Parse(commands[4]) >= 0 && int.Parse(commands[4]) < cols
                &&
                commands.Length==5;
                

        }
        static void matrixPr(int raws, int cols, string[,] matrix)
        {
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
