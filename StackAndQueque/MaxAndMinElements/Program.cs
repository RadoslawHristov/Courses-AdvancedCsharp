using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_ElementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int quest = int.Parse(Console.ReadLine());

            Stack<int> element = new Stack<int>();

            for (int i = 0; i < quest; i++)
            {
                int[] comand = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                if (comand[0] == 1)
                {
                    element.Push(comand[1]);
                }
                else if (comand[0] == 2)
                {
                    if (element.Count > 0)
                    {
                        element.Pop();
                    }
                }
                else if (comand[0] == 3)
                {
                    if (element.Count > 0)
                    {
                        Console.WriteLine(element.Max());
                    }
                }
                else if (comand[0] == 4)
                {
                    if (element.Count > 0)
                    {
                         Console.WriteLine(element.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", element));
        }
    }
}
