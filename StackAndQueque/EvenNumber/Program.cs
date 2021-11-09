using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> evenNumber = new Queue<int>();

            for (int i = 0; i < inputNumber.Length; i++)
            {
                
                if (inputNumber[i] % 2==0 )
                {
                    evenNumber.Enqueue(inputNumber[i]);
                }
            }

            Console.WriteLine(String.Join(", ",evenNumber));
            
          
        }
    }
}
