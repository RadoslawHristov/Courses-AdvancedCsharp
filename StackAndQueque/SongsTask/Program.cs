using System;
using System.Collections.Generic;

namespace _06._Songs_Queue_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine().Split(", ");

            Queue<string> allSongs = new Queue<string>(inputSongs);

            while (allSongs.Count > 0)
            {
                string comand = Console.ReadLine();

                if (comand=="Play")
                {
                    allSongs.Dequeue();
                }
                else if (comand.Contains("Add"))
                {
                    string song = comand.Substring(4);
                    if (allSongs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        allSongs.Enqueue(song);
                    }
                }
                else if (comand.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", allSongs));
                }

                if (allSongs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                }
            }
        }
    }
}
