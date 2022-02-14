using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;

namespace _9._Miner_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            char[][] gameField = new char[sizeMatrix][];

            string[] moveComand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int moveCount = moveComand.Length;
            int count = 0;
            int minerRow = 0;
            int minerCol = 0;

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                gameField[i] = input;

                //Shearch a position miner 's' and count of coals
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'c')
                    {
                        count++;
                    }

                    if (input[j] == 's')
                    {
                        minerRow = i;
                        minerCol = j;
                    }
                }
            }


            for (int i = 0; i < moveComand.Length; i++)
            {
                string curenComand = moveComand[i];
                moveCount--;
                
                // curenComand check a valid possition on gameField
                if (ComandisValidPosition(gameField, minerRow, minerCol, curenComand))
                {

                    if (curenComand == "up")
                    {
                        minerRow -= 1;
                        if (gameField[minerRow][minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                            break;
                        }

                        if (gameField[minerRow][minerCol] == 'c')
                        {
                            if (count-1 <= 0)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                break;
                            }
                            else
                            {
                                count--;
                            }
                        }

                        gameField[minerRow][minerCol] = 's';
                        gameField[minerRow+1][minerCol] = '*';

                    }
                    else if (curenComand == "down")
                    {
                        minerRow += 1;
                        if (gameField[minerRow][minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                            break;
                        }
                        if (gameField[minerRow][minerCol] == 'c')
                        {
                            if (count - 1 <= 0)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                break;
                            }
                            else
                            {
                                count--;
                            }
                        }

                        gameField[minerRow][minerCol] = 's';
                        gameField[minerRow -1][minerCol] = '*';
                    }
                    else if (curenComand == "right")
                    {
                        minerCol += 1;
                        if (gameField[minerRow][minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                            break;
                        }

                        if (gameField[minerRow][minerCol] == 'c')
                        {
                            if (count - 1 <= 0)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                break;
                            }
                            else
                            {
                                count--;
                            }
                        }

                        gameField[minerRow][minerCol] = 's';
                        gameField[minerRow][minerCol-1] = '*';
                    }
                    else if (curenComand == "left")
                    {
                        minerCol -= 1;
                        if (gameField[minerRow][minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                            break;
                        }

                        if (gameField[minerRow][minerCol] == 'c')
                        {
                            if (count - 1 <= 0)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                break;
                            }
                            else
                            {
                                count--;
                            }
                        }

                        gameField[minerRow][minerCol] = 's';
                        gameField[minerRow][minerCol+1] = '*';
                    }
                }
                if (moveCount == 0)
                {
                    Console.WriteLine($"{count} coals left. ({minerRow}, {minerCol})");
                }
            }
        }


        private static bool ComandisValidPosition(char[][] gameField, int minerRow, int minerCol, string curenComand)
        {
            bool isValidIndex = false;

            if (curenComand == "up" && minerRow - 1 >= 0 && minerRow < gameField.Length
            && minerCol >= 0 && minerCol < gameField[minerRow].Length)
            {
                isValidIndex = true;
            }
            else if (curenComand == "down" && minerRow >= 0 && minerRow + 1 < gameField.Length
                     && minerCol >= 0 && minerCol < gameField[minerRow].Length)
            {
                isValidIndex = true;
            }
            else if (curenComand == "right" && minerRow >= 0 && minerRow < gameField.Length
                     && minerCol >= 0 && minerCol + 1 < gameField[minerRow].Length)
            {
                isValidIndex = true;
            }
            else if (curenComand == "left" && minerRow >= 0 && minerRow < gameField.Length
                     && minerCol - 1 >= 0 && minerCol < gameField[minerRow].Length)
            {
                isValidIndex = true;
            }

            return isValidIndex;
        }
    }
}
