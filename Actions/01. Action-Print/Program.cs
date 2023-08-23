using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action <string[]>PrName = name => Console.WriteLine(String.Join(Environment.NewLine ,name));

            PrName(name);
        }

    }
}
