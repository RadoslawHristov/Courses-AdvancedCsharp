using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int> allfunction = null;

            string comand = Console.ReadLine();

            GetComandAndReturnResult(inputNumber, allfunction, comand);
        }

        private static void GetComandAndReturnResult(List<int> inputNumber, Func<int, int> allfunction, string comand)
        {
            while (comand != "end")
            {
                switch (comand)
                {
                    case "add":
                        allfunction = x => x + 1;
                        break;
                    case "subtract":
                        allfunction = x => x - 1;
                        break;
                    case "multiply":
                        allfunction = x => x * 2;
                        break;
                }

                if (comand == "print")
                {
                    Console.WriteLine(String.Join(" ", inputNumber));
                }
                else
                {
                    inputNumber = inputNumber.Select(allfunction).ToList();
                }
                comand = Console.ReadLine();
            }
        }
    }
}
