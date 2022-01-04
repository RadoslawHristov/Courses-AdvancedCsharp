using System;
using System.Linq;

namespace _06._Reverse_And_Exclude_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
              
            int numForDivide = int.Parse(Console.ReadLine());

            Func<int, bool> results = x => x % numForDivide != 0;
            
            var Result = numbers.Reverse().Where(results);

            Console.WriteLine(string.Join(" ",Result));
        }
    }
}
