using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            int count = 0;
            while (input != "End")
            {
                if (input != "Paid")
                {
                   names.Enqueue(input);
                   count++;
                }
                else if(input=="Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                        count--;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} people remaining.");
        }
    }
}
