using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> upper = n => n[0] == n.ToUpper()[0];
            string[] upperCaseWord = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w=>upper(w))
                .ToArray();
               

            Console.WriteLine(string.Join(Environment.NewLine,upperCaseWord));
        }
    }
}
