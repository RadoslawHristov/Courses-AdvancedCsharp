using System;
using System.Collections.Generic;
using System.Linq;

namespace BeaverWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMatrix = int.Parse(Console.ReadLine());

            char[][] field = new char[countMatrix][];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    field[i] = input;
                }
            }

            int row = 0;
            int col = 0;
            int countBranches = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'B')
                    {
                        row = i;
                        col = j;
                    }

                    if (char.IsLower(field[i][j]))
                    {
                        countBranches++;
                    }
                }
            }

            string comand = Console.ReadLine();
            List<string> branches = new List<string>();

            while (comand != "end")
            {
                if (countBranches == 0)
                {
                    break;
                }
                if (comand == "up")// work corectly
                {
                    if (row - 1 < 0)
                    {
                        comand = Console.ReadLine();
                        if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count - 1);
                        }
                        continue;
                    }

                    if (field[row - 1][col] == 'F')
                    {
                        if (row - 1 == 0)
                        {
                            field[row][col] = '-';
                            field[row - 1][col] = '-';
                            row = field.GetLength(0) - 1;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                        else if (row - 1 != 0)
                        {
                            field[row][col] = '-';
                            field[row - 1][col] = '-';
                            row = field.GetLength(0) - 1;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                    }
                    if (char.IsLower(field[row - 1][col]))
                    {
                        branches.Add(field[row - 1][col].ToString());
                        row--;
                        field[row][col] = 'B';
                        field[row + 1][col] = '-';
                        countBranches--;
                        comand = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        row--;
                        field[row][col] = 'B';
                        field[row + 1][col] = '-';
                    }
                }
                else if (comand == "down")// not tested houw work
                {
                    if (row + 1 > field[row].Length - 1)
                    {
                        comand = Console.ReadLine();
                        if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count - 1);
                        }
                        continue;
                    }
                    if (field[row + 1][col] == 'F')
                    {
                        if (row+1 == field.Length - 1)
                        {
                            field[row][col] = '-';
                            row = 0;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                        else if (row+1 != field.Length-1)
                        {
                            field[row][col] = '-';
                            row = 0;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                    }
                    if (char.IsLower(field[row + 1][col]))
                    {
                        branches.Add(field[row][col].ToString());
                        row++;
                        field[row][col] = 'B';
                        field[row - 1][col] = '-';
                        countBranches--;
                        comand = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        row++;
                        field[row][col] = 'B';
                        field[row - 1][col] = '-';
                    }
                }
                else if (comand == "left")//not tested work
                {
                    if (col - 1 < 0)
                    {
                        comand = Console.ReadLine();
                        if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count - 1);
                        }
                        continue;
                    }
                    if (field[row][col - 1] == 'F')
                    {

                        if (col-1 == 0)
                        {
                            field[row][col] = '-';
                            col = field[row].Length - 1;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                        else if (col-1 != 0)
                        {
                            field[row][col] = '-';
                            col = field[row].Length - 1;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                    }
                    if (char.IsLower(field[row][col - 1]))
                    {
                        branches.Add(field[row][col].ToString());
                        col--;
                        field[row][col] = 'B';
                        field[row][col + 1] = '-';
                        countBranches--;
                        comand = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        col--;
                        field[row][col] = 'B';
                        field[row][col + 1] = '-';
                    }
                }
                else if (comand == "right")//work corectly
                {
                    if (col + 1 > field[row].Length - 1)
                    {
                        comand = Console.ReadLine();
                        if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count - 1);
                        }
                        continue;
                    }
                    if (field[row][col + 1] == 'F')
                    {

                        if (col+1 == field[row].Length - 1)
                        {
                            field[row][col] = '-';
                            col = 0;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                        else if (col+1 !=field[row].Length-1)
                        {

                            field[row][col] = '-';
                            col = 0;
                            field[row][col] = 'B';
                            comand = Console.ReadLine();
                            continue;
                        }
                    }
                    if (char.IsLower(field[row][col + 1]))
                    {
                        branches.Add(field[row][col + 1].ToString());
                        col++;
                        field[row][col] = 'B';
                        field[row][col - 1] = '-';
                        countBranches--;
                        comand = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        col++;
                        field[row][col] = 'B';
                        field[row][col - 1] = '-';
                    }
                }

                comand = Console.ReadLine();
            }

            if (countBranches > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {countBranches} branches left.");
                for (int i = 0; i < field.Length; i++)
                {
                    for (int j = 0; j < field[i].Length; j++)
                    {
                        Console.Write(string.Join(" ", field[i][j] + " "));
                    }

                    Console.WriteLine();
                }
            }
            else if (countBranches == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                for (int i = 0; i < field.Length; i++)
                {
                    for (int j = 0; j < field[i].Length; j++)
                    {
                        Console.Write(string.Join(" ", field[i][j] + " "));
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
