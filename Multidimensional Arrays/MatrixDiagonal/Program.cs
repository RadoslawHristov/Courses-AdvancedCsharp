using System;
using System.Linq;

namespace _3._Primary_Diagonal_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int sumDiag = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (row==col)
                    {
                        sumDiag += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sumDiag);

        }
    }
}
