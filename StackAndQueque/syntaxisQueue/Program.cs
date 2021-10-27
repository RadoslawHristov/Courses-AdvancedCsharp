using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_OperationsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputnumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] enqunumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int remove = inputnumber[1];
            int megicnum = inputnumber[2];
            Queue<int> resultnumber = new Queue<int>(enqunumber);


            if (remove <=resultnumber.Count)
            {
                for (int i = 0; i < remove; i++)
                {
                    resultnumber.Dequeue();
                }
            }

            if (resultnumber.Contains(megicnum))
            {
                Console.WriteLine("true");
            }
            else if(resultnumber.Count > 0)
            {
                Console.WriteLine(resultnumber.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
