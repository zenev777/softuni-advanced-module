using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max=int.MinValue;
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
           
            Stack st = new Stack();
           
            Stack stMin = st;
            Stack stMax = st;
            for (int i = 0; i < n; i++)
            {
                string[] commands = input.Split().ToArray();
                int mainCommand = int.Parse(commands[0]);

                if (mainCommand==1)
                {
                    int element = int.Parse(commands[1]);
                    st.Push(element);
                }
                else if (mainCommand==2)
                {
                    st.Pop();
                }
                else if (mainCommand==3)
                {
                    if (st.Count > 0)
                    {
                        for (int j = 0; j < st.Count; j++)
                        {
                            if ((int)stMax.Peek() > max)
                            {
                                max = (int)stMax.Peek();
                                
                            }
                        }
                        Console.WriteLine(max);
                    }
                }
                else if (mainCommand == 4)
                {
                    if (st.Count > 0)
                    {
                        for (int j = 0; j < st.Count; j++)
                        {
                            if ((int)stMin.Peek() < min)
                            {
                                min = (int)stMin.Peek();
                                
                            }
                        }
                        Console.WriteLine(min);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in st)
            {
                Console.Write(String.Join(", ", item));
            }
        }
    }
}
