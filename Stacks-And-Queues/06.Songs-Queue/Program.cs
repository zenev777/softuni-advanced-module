using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] start = Console.ReadLine().Split(", ").ToArray();
            string[] input = Console.ReadLine().Split().ToArray();
            string singleSong = string.Empty;
            Queue songs = new Queue();

            for (int i = 0; i < start.Length; i++)
            {
                songs.Enqueue(start[i]);
            }

            while (true)
            {
            string command = input[0];
                if (command == "Play")
                {
                    songs.Dequeue();
                    if (songs.Count==0)
                    {
                        Console.WriteLine("No more songs!");
                        return;
                    }
                }
                else if (command == "Add")
                {

                    for (int i = 1; i < input.Length; i++)
                    {
                        singleSong +=input[i]+" ";
                    }
                       string sing = singleSong.Remove(singleSong.Length-1,1);

                    if (!songs.Contains(sing))
                    {
                        songs.Enqueue(singleSong); 
                    }
                    else
                    {
                        Console.WriteLine($"{singleSong}is already contained!");
                    }
                    sing = String.Empty;
                    singleSong = String.Empty;
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
