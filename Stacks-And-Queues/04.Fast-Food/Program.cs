using System;
using System.Collections;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limitOfFood =int.Parse(Console.ReadLine());
            
            string [] qnty = Console.ReadLine().Split().ToArray();

            int max = int.MinValue;

            Queue queue = new Queue();

            for (int i = 0; i < qnty.Length; i++)
            {
                queue.Enqueue(int.Parse(qnty[i]));

                int currQ = int.Parse(qnty[i]);  
                
                if (currQ>max)
                {
                    max = currQ;
                }

            }

            for (int i = 0; i < qnty.Length; i++)
            {
                if ((int)queue.Peek() <= limitOfFood)
                {
                    limitOfFood -= (int)queue.Peek();
                    queue.Dequeue();
                    
                }
                else
                {
                    break;
                }

                if ((int)queue.Count==0)
                {
                    Console.WriteLine(max);
                    Console.WriteLine("Orders complete");
                    return;
                }
            }

            if ((int)queue.Peek() >= limitOfFood)
            {
                Console.WriteLine(max);
                Console.Write("Orders left: ");
                foreach (var item in queue)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
