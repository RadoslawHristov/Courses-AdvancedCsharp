using System;
using System.Collections.Generic;

namespace _04._Even_Times_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbercount = new Dictionary<int, int>();


            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!numbercount.ContainsKey(input))
                {
                    numbercount.Add(input,0);
                }

                numbercount[input] += 1;
            }

            foreach (var item in numbercount)
            {
                if (item.Value % 2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
