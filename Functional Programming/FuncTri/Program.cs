using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> results = (names, ascisum) => names.Sum(x => x) >= sum;
            Func<List<string>, string> oneNames = (allnames) =>
                allnames.FirstOrDefault(x=> results(x, sum));

            Console.WriteLine(oneNames(names));
        }
    }
}