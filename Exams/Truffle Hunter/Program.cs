using System;
using System.Linq;

namespace Truffle_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            char[][] field = new char[sizeMatrix][];

            for (int i = 0; i < field.Length; i++)
            {
                char[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    field[i] = input;
                }
            }

            int blackTruf = 0;
            int whitetruf = 0;
            int summerTruf = 0;

            int countWildb = 0;

            string comand = Console.ReadLine();

            while (comand != "Stop the hunt")
            {
                string[] splited = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string actions = splited[0];

                if (actions == "Collect")
                {
                    int row = int.Parse(splited[1]);
                    int col = int.Parse(splited[2]);
                    if (field[row][col] == 'B')
                    {
                        blackTruf++;
                        field[row][col] = '-';
                    }
                    else if (field[row][col] == 'W')
                    {
                        whitetruf++;
                        field[row][col] = '-';
                    }
                    else if (field[row][col] == 'S')
                    {
                        summerTruf++;
                        field[row][col] = '-';
                    }
                }
                else if (actions == "Wild_Boar")
                {
                    int row = int.Parse(splited[1]);
                    int col = int.Parse(splited[2]);
                    string direction = splited[3];

                    if (direction == "up")
                    {
                        for (int i = row; i >= 0; i -= 2)
                        {
                            if (field[i][col] == 'W' || field[i][col] == 'S' || field[i][col] == 'B')
                            {
                                countWildb++;
                                field[row][col] = '-';
                                field[i][col] = '-';
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = row; i < field.Length-1; i+=2)
                        {
                            if (field[i][col] == 'W' || field[i][col] == 'S' || field[i][col] == 'B')
                            {
                                countWildb++;
                                field[row][col] = '-';
                                field[i][col] = '-';
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = col; i >= 0; i -= 2)
                        {
                            if (field[row][i] == 'W' || field[row][i] == 'S' || field[row][i] == 'B')
                            {
                                countWildb++;
                                field[row][col] = '-';
                                field[row][i] = '-';
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = col; i <= field[row].Length - 1; i += 2)
                        {
                            if (field[row][i] == 'W' || field[row][i] == 'S' || field[row][i] == 'B')
                            {
                                countWildb++;
                                field[row][col] = '-';
                                field[row][i] = '-';
                            }
                        }
                    }
                }
                comand = Console.ReadLine();
            }

            Console.WriteLine($"Peter manages to harvest {blackTruf} black, {summerTruf} summer, and {whitetruf} white truffles.");
            Console.WriteLine($"The wild boar has eaten {countWildb} truffles.");

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
