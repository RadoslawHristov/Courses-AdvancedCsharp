using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> numberN = new HashSet<int>();
            HashSet<int> numberM = new HashSet<int>();
            int sum = n + m;
            for (int i = 0; i < sum ; i++)
            {
                int secInput=int.Parse(Console.ReadLine());
                if (i < n)
                {
                    numberN.Add(secInput);
                }
                else
                {
                    numberM.Add(secInput);
                }

               
            }

            foreach (var item in numberN)
            {
                if (numberM.Contains(item))
                {
                     Console.Write(item + " ");
                }
            }
        }
    }
}
