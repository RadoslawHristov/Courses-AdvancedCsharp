using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int CountBag = int.Parse(Console.ReadLine());
            Stack<int> clothnes = new Stack<int>(intput);
            int sum = 0;
            int counts = 1;
            while (clothnes.Count > 0)
            {
                
                sum += clothnes.Peek();
                if (sum <=CountBag)
                {
                    clothnes.Pop();
                }
                else
                {
                    counts++;
                    sum = 0;
                }
            }

            Console.WriteLine(counts);
        }
    }
}
