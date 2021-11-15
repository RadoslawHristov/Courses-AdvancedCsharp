using System;

namespace _1._Sum_Matrix_Elements_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstline = Console.ReadLine();
            string[] second = firstline.Split(", ");
            int rows = int.Parse(second[0]);
            int cols = int.Parse(second[1]);
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                string[] Line = input.Split(", ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Line[col]);
                }
            }
            int sumMatrix = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sumMatrix += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sumMatrix);
        }
    }
}
