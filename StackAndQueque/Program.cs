using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_OperationsExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numOfComand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int[] pushelement = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int pop = numOfComand[1];
            int megicnum = numOfComand[2];


            Stack<int> number = new Stack<int>(pushelement);

            if (pop <= number.Count)
            {
                for (int i = 0; i < pop; i++)
                {
                    number.Pop();
                }
            }
           
            int minValue = int.MaxValue;
            if (number.Contains(megicnum))
            {
                Console.WriteLine("true");
            }
            else if(number.Count > 0)
            {
                Console.WriteLine(number.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
