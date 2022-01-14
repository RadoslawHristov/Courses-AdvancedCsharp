using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> CountOfNumber = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (CountOfNumber.ContainsKey(input[i]))
                {
                    CountOfNumber[input[i]] += 1;
                }
                if (!CountOfNumber.ContainsKey(input[i]))
                {
                    CountOfNumber.Add(input[i],1);
                }
            }

            foreach (var item in CountOfNumber)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
