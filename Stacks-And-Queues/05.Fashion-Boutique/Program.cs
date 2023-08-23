using System;
using System.Collections;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int capacityClone = capacity;
            int left = 0;
            Stack st = new Stack();
           
            int racks = 0;
           
            
            for (int i = 0; i < clothes.Length; i++)
            {
                st.Push(clothes[i]);
            }
            for (int i = 0; i < clothes.Length; i++)
            {
                if ((int)st.Peek()<=capacity)
                {
                    capacity -= (int)st.Peek();
                    st.Pop();
                }
                else if ((int)st.Peek() >= capacity)
                {
                    left = (int)st.Peek() - capacity;
                    capacity = capacityClone;
                    capacity -= left;
                    st.Pop();
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
