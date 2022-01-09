using System;
using System.Collections.Generic;

namespace _03._Periodic_Table_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            SortedSet<string> result = new SortedSet<string>();


            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                     result.Add(item);
                }
            }

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
        
    }
}
