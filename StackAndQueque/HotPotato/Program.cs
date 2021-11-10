using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args) 
        {
            string[] input = Console.ReadLine().Split();
            int numoutOfGame = int.Parse(Console.ReadLine());

            Queue<string> namesPotato = new Queue<string>(input);
            while (namesPotato.Count !=1)
            {
                for (int i = 1; i < numoutOfGame; i++)
                {
                    namesPotato.Enqueue(namesPotato.Dequeue());
                }

                Console.WriteLine($"Removed {namesPotato.Dequeue()}");
            }
            Console.WriteLine($"Last is {namesPotato.Dequeue()}");
        }
    }
}
