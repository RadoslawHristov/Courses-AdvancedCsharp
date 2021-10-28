using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputnumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < inputnumber.Length; i++)
            {
                numbers.Push(inputnumber[i]);
            }

            string comand = Console.ReadLine().ToLower();
            while (comand !="end")
            {
                string[] line = comand.Split(" ");
                string cmd = line[0];
                if (cmd=="add")
                {
                    numbers.Push(int.Parse(line[1]));
                    numbers.Push(int.Parse(line[2]));
                }
                else if (cmd=="remove")
                {
                    int num = int.Parse(line[1]);
                    if (numbers.Count >= num)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                comand = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
