using System;
using System.Linq;

namespace _07._Predicate_For_Names_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> resultNames = z => z.Length <= count;

            var filteredNames = names.Where(resultNames);

            Console.WriteLine(string.Join(Environment.NewLine,filteredNames));
        }
    }
}
