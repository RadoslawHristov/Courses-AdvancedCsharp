using System;
using System.Data;
using System.Linq;

namespace _1._Diagonal_Difference_Exs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputNumber = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputNumber[j];
                }
            }

            int sumLeftDiag = 0;
            int sumRightDiag = 0;

            int matrixLeftSum = GetMatrixLeftDiag(matrix, sumLeftDiag);
            int matrixRightSum = GetMatrixRightDiag(matrix, sumRightDiag);

            Console.WriteLine(Math.Abs(matrixRightSum - matrixLeftSum));
        }

        private static int GetMatrixRightDiag(int[,] matrix, int sumRightDiag)
        {
            int count = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumRightDiag+=matrix[i, count];
                count--;
            }

            return sumRightDiag;
        }

        private static int GetMatrixLeftDiag(int[,] matrix, int sumLeftDiag)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumLeftDiag += matrix[i, i];
            }

            return sumLeftDiag;
        }
    }
}
