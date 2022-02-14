using System;
using System.Linq;

namespace _8._Bombs_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[,] field = new int[count, count];

            field = ReadMatrix(field);

            int[] bombCordinate = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < bombCordinate.Length; i += 2)
            {
                int rowBomb = bombCordinate[i];
                int colBomb = bombCordinate[i + 1];

                if (isValid(rowBomb, colBomb, field) && field[rowBomb, colBomb] > 0)
                {
                    int bombDamage = field[rowBomb, colBomb];
                    if (isValid(rowBomb - 1, colBomb, field) && field[rowBomb - 1, colBomb] > 0)
                    {
                        field[rowBomb - 1, colBomb] -= bombDamage;
                    }
                    if (isValid(rowBomb + 1, colBomb, field) && field[rowBomb + 1, colBomb] > 0)
                    {
                        field[rowBomb + 1, colBomb] -= bombDamage;
                    }
                    if (isValid(rowBomb - 1, colBomb - 1, field) && field[rowBomb - 1, colBomb - 1] > 0)
                    {
                        field[rowBomb - 1, colBomb - 1] -= bombDamage;
                    }
                    if (isValid(rowBomb - 1, colBomb + 1, field) && field[rowBomb - 1, colBomb + 1] > 0)
                    {
                        field[rowBomb - 1, colBomb + 1] -= bombDamage;
                    }
                    if (isValid(rowBomb + 1, colBomb - 1, field) && field[rowBomb + 1, colBomb - 1] > 0)
                    {
                        field[rowBomb + 1, colBomb - 1] -= bombDamage;
                    }
                    if (isValid(rowBomb + 1, colBomb + 1, field) && field[rowBomb + 1, colBomb + 1] > 0)
                    {
                        field[rowBomb + 1, colBomb + 1] -= bombDamage;
                    }
                    if (isValid(rowBomb, colBomb - 1, field) && field[rowBomb, colBomb - 1] > 0)
                    {
                        field[rowBomb, colBomb - 1] -= bombDamage;
                    }
                    if (isValid(rowBomb, colBomb + 1, field) && field[rowBomb, colBomb + 1] > 0)
                    {
                        field[rowBomb, colBomb + 1] -= bombDamage;
                    }

                    field[rowBomb, colBomb] = 0;
                }
            }

            int countOfcell = 0;
            int sum = 0;

            GetFieldPosNumberAndCountPositiveNumber(field, countOfcell, sum);
            PrintField(field);
        }

        private static void GetFieldPosNumberAndCountPositiveNumber(int[,] field, int countOfcell, int sum)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] > 0)
                    {
                        sum += field[i, j];
                        countOfcell++;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {countOfcell}");
            Console.WriteLine($"Sum: {sum}");
        }

        private static void PrintField(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool isValid(int rowBomb, int colBomb, int[,] field)
        {
            return (rowBomb >= 0 && rowBomb < field.GetLength(0) && colBomb >= 0 && colBomb < field.GetLength(1));
        }

        private static int[,] ReadMatrix(int[,] field)
        {

            for (int i = 0; i < field.GetLength(0); i++)
            {
                int[] inputNumber = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = inputNumber[j];
                }
            }
            return field;
        }
    }
}
