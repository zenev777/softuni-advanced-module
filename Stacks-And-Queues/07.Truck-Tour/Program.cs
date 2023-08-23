using System;
using System.Collections;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            
            st.Push("a");
            st.Push("b");
            st.Push("c");
            st.Push("d");
            foreach (var item in st)
            {

            Console.Write(string.Join(", ",item));
            }
        }
    }
}
