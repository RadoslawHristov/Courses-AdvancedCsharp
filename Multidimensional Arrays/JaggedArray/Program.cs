using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var rowls = int.Parse(Console.ReadLine());

            var jagged = new double[rowls][];
            for (var i = 0; i < rowls; i++)
            {
                var inputs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jagged[i] = inputs;
            }

            for (var i = 0; i < jagged.Length - 1; i++)
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (var j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (var j = 0; j < jagged[i].Length; j++) jagged[i][j] /= 2;

                    for (var j = 0; j < jagged[i + 1].Length; j++) jagged[i + 1][j] /= 2;
                }

            var input = Console.ReadLine();

            while (input != "End")
            {
                var comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var comd = comand[0];
                var row = int.Parse(comand[1]);
                var col = int.Parse(comand[2]);
                var value = int.Parse(comand[3]);

                if (!(row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (comd == "Add")
                {
                    jagged[row][col] += value;
                }
                else
                {
                    jagged[row][col] -= value;
                }

                input = Console.ReadLine();
            }

            for (var i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }

    }
}