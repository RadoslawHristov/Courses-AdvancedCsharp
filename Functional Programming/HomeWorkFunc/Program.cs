using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = Console.ReadLine()
                .Split()
                .ToList();

            Action<string> dropSir = x => Console.WriteLine("Sir"+ " " + x);
            name.ForEach(dropSir);
        }
    }
}
