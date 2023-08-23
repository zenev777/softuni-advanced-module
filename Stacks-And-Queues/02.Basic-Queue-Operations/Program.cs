using System;
using System.Collections;
using System.Linq;

namespace Stacks_and_Queues___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            int min = int.MaxValue;
            string[] stackColl = Console.ReadLine().Split().ToArray();

            Queue st = new Queue();
            Queue cloned = st;
            for (int i = 0; i < n; i++)
            {
                st.Enqueue(int.Parse(stackColl[i]));
            }
            for (int i = 0; i < s; i++)
            {
                st.Dequeue();
            }

            if (st.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (st.Count > 0)
            {
                for (int i = 0; i < st.Count; i++)
                {
                    if ((int)cloned.Peek() < min)
                    {
                        min = (int)st.Peek();
                        cloned.Dequeue();
                    }
                }
                Console.WriteLine(min);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
