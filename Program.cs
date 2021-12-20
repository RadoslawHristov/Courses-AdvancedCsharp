using System;
using System.Linq;

namespace _04._Add_VAT_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vats = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach (var item in vats)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
