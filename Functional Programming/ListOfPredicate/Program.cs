using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int endDigit = int.Parse(Console.ReadLine());

            List<int> devider = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            for (int i = 1; i <= endDigit; i++)
            {
                result.Add(i);
            }

            Console.WriteLine(string.Join(" ", result));
        }



        private static bool DivedDigit(int i, List<int> devider)
        {
            bool isDived = true;

            foreach (var item in devider)
            {
                if (i % item != 0)
                {
                    isDived = false;
                }
            }
            return isDived;
        }
    }
}
