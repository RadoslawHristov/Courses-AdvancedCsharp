using System;
using System.Linq;

namespace The_Battle_of_the_Five_Armies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());

            char[,] field = new char[rows, rows];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                string inputField = Console.ReadLine();

                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = inputField[j];
                }
            }

            int Arow = 0;
            int Acol = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 'A')
                    {
                        Arow = i;
                        Acol = j;
                        break;
                    }
                }
            }



            while (true)
            {
                string[] comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string moves = comand[0];
                int row = int.Parse(comand[1]);
                int col = int.Parse(comand[2]);


                field[row, col] = 'O';
                field[Arow, Acol] = '-';
                armor--;
                if (moves == "up" && Arow - 1 >= 0)
                {
                    Arow--;
                }
                else if (moves == "down" && Arow + 1 <= rows)
                {
                    Arow++;
                }
                else if (moves == "left" && Acol - 1 >= 0)
                {
                    Acol--;
                }
                else if (moves == "right" && Acol + 1 <= field.GetLength(1))
                {
                    Acol++;
                }

                if (field[Arow, Acol] == 'O')
                {
                    armor -= 2;
                }

                if (armor <= 0)
                {
                    field[Arow, Acol] = 'X';
                    Console.WriteLine($"The army was defeated at {Arow};{Acol}.");
                    break;
                }

                if (field[Arow, Acol] == 'M')
                {
                    field[Arow, Acol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }

                field[Arow, Acol] = 'A';
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }

                Console.WriteLine();
            }
            // 100/100
        }
    }
}
