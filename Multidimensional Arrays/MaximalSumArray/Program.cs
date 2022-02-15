using System;
using System.Linq;

namespace _3._Maximal_Sum_Exs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNumber = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumber[col];
                }
            }


            int sum = 0;
            int maxSum = 0;
            int indexRow = 0;
            int indexCol = 0;


            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j]
                          + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1]
                          + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        indexRow = i;
                        indexCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = indexRow; i < indexRow + 3; i++)
            {
                for (int j = indexCol; j < indexCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
