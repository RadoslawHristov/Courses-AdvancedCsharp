using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles_Exersise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cups = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var bottle = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var cup = new Queue<int>(cups);
            var botle = new Stack<int>(bottle);
            var water = 0;
            bool isbotle = true;
            int curentcup = 0;
            while (cup.Any() && botle.Any())
            {
                if (isbotle)
                {
                      curentcup = cup.Peek();
                      isbotle = false;
                }
                var curentbotle = botle.Pop();

                if (curentcup -curentbotle <=0)
                {
                    water += curentbotle - curentcup;
                    cup.Dequeue();
                    isbotle = true;
                }
                else
                {
                    curentcup -= curentbotle;
                }

            }

            if (cup.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ",cup)}");
            }
            if (botle.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",botle)}");
            }

            Console.WriteLine($"Wasted litters of water: {water}");
        }
    }
}