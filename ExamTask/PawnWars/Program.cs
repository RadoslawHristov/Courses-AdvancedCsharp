using System;
using System.Data;

namespace _02.PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[8, 8];
            int whiteRow = -2;
            int whiteCol = -2;
            int blackRow = -2;
            int blackCol = -2;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (row[j] == 'w')
                    {
                        whiteRow = i;
                        whiteCol = j;
                    }
                    else if (row[j] == 'b')
                    {
                        blackRow = i;
                        blackCol = j;
                    }

                    matrix[i, j] = row[j].ToString();
                }
            }

            while (true)
            {
                if (whiteRow - 1 > 0)
                {
                    whiteRow--;

                    if (whiteRow == blackRow && whiteCol - 1 == blackCol)
                    {
                        Console.WriteLine($"Game over! White capture on {ChessCol(blackCol)}{8 - whiteRow}.");
                        return;
                    }
                    else if (whiteRow == blackRow && whiteCol + 1 == blackCol)
                    {
                        Console.WriteLine($"Game over! White capture on {ChessCol(blackCol)}{8 - whiteRow}.");
                        return;
                    }
                }
                if (whiteRow - 1 == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {ChessCol(whiteCol)}8.");
                    return;
                }

                if (blackRow + 1 < 7)
                {
                    blackRow++;

                    if (blackRow == whiteRow && blackCol - 1 == whiteCol)
                    {
                        Console.WriteLine($"Game over! Black capture on {ChessCol(whiteCol)}{8 - blackRow}.");
                        return;
                    }
                    else if (blackRow == whiteRow && blackCol + 1 == whiteCol)
                    {
                        Console.WriteLine($"Game over! Black capture on {ChessCol(whiteCol)}{8 - blackRow}.");
                        return;
                    }
                }
                if (blackRow + 1 == 7)
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {ChessCol(blackCol)}1.");
                    return;
                }
            }
        }

        private static string ChessCol(int n)
        {
            if (n == 0)
            {
                return "a";
            }
            else if (n == 1)
            {
                return "b";
            }
            else if (n == 2)
            {
                return "c";
            }
            else if (n == 3)
            {
                return "d";
            }
            else if (n == 4)
            {
                return "e";
            }
            else if (n == 5)
            {
                return "f";
            }
            else if (n == 6)
            {
                return "g";
            }
            else
            {
                return "h";
            }
        }
    }
}