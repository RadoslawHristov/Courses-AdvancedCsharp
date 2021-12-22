using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            //Action<List<int>, string> ApplyArithmetics = (nums, opr) =>
            //{
            //    if (opr == "add")
            //    {
            //        nums = nums.Select(n => ++n).ToList();
            //    }
            //    else if (opr == "multiply")
            //    {
            //        nums = nums.Select(n => n = n * 2).ToList();
            //    }
            //    else if (opr == "subtract")
            //    {
            //        nums = nums.Select(n => --n).ToList();
            //    }
            //    else if (opr == "print")
            //    {
            //        Console.WriteLine(string.Join(" ", nums));
            //    }
            //};

            while (input != "end")
            {
                if (input == "add")
                {
                    numbers = numbers.Select(x => x + 1).ToList();
                }
                else if (input == "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToList();
                }
                else if (input == "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToList();
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                input = Console.ReadLine();
            }
        }
    }
}
