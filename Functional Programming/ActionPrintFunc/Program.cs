using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Action<string> output = x=>Console.WriteLine(x);
            names.ForEach(output);
        }
    }
}
