using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int countComand = int.Parse(Console.ReadLine());

            char[,] gameField = new char[sizeMatrix, sizeMatrix];

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = input[j];
                }
            }

            int rowHero = 0;
            int Colhero = 0;

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (gameField[i, j] == 'f')
                    {
                        rowHero = i;
                        Colhero = j;
                    }
                }
            }
            bool isEnd = false;

            for (int i = 0; i < countComand; i++)
            {
                string position = Console.ReadLine();

                if (position == "up")
                {
                    if (rowHero - 1 < 0)
                    {
                        gameField[rowHero, Colhero] = '-';
                        rowHero = gameField.GetLength(0) - 1;

                        if (gameField[rowHero, Colhero] == 'F')
                        {
                            isEnd = true;
                            gameField[rowHero, Colhero] = '-';
                            gameField[rowHero - 1, Colhero] = 'f';
                            break;
                        }
                        gameField[rowHero, Colhero] = 'f';
                        continue;
                    }

                    if (gameField[rowHero - 1, Colhero] == 'B')
                    {
                        rowHero -= 2;
                        gameField[rowHero + 2, Colhero] = '-';
                        gameField[rowHero, Colhero] = 'f';
                        continue;
                    }
                    if (gameField[rowHero - 1, Colhero] == 'T')
                    {
                        continue;
                    }
                    if (gameField[rowHero - 1, Colhero] == 'F')
                    {
                        isEnd = true;
                        gameField[rowHero, Colhero] = '-';
                        gameField[rowHero - 1, Colhero] = 'f';
                        break;
                    }
                    if (gameField[rowHero - 1, Colhero] != 'B' && gameField[rowHero - 1, Colhero] != 'T'
                        && gameField[rowHero - 1, Colhero] != 'F')
                    {
                        gameField[rowHero, Colhero] = '-';
                        rowHero--;
                        gameField[rowHero, Colhero] = 'f';
                    }
                }
                else if (position == "down")
                {

                    if (gameField[rowHero + 1, Colhero] == 'T')
                    {
                        continue;
                    }
                    if (gameField[rowHero + 1, Colhero] == 'F')
                    {
                        isEnd = true;
                        gameField[rowHero, Colhero] = '-';
                        gameField[rowHero + 1, Colhero] = 'f';
                        break;
                    }
                    if (gameField[rowHero + 1, Colhero] == 'B')
                    {
                        gameField[rowHero, Colhero] = '-';
                        rowHero += 2;
                        gameField[rowHero, Colhero] = 'f';
                    }
                    if (rowHero == gameField.GetLength(0) - 1)
                    {
                        gameField[rowHero, Colhero] = '-';
                        rowHero = 0;
                        gameField[rowHero, Colhero] = 'f';
                    }
                    
                    if (gameField[rowHero + 1, Colhero] != 'B' && gameField[rowHero + 1, Colhero] != 'T'
                             && gameField[rowHero + 1, Colhero] != 'F')
                    {
                        gameField[rowHero, Colhero] = '-';
                        rowHero++;
                        gameField[rowHero, Colhero] = 'f';
                    }
                }
                else if (position == "left")
                {
                    if (gameField[rowHero, Colhero - 1] == 'T')
                    {
                        continue;
                    }

                    if (gameField[rowHero, Colhero - 1] != 'B' && gameField[rowHero, Colhero - 1] != 'T'
                             && gameField[rowHero, Colhero - 1] != 'F')
                    {
                        gameField[rowHero, Colhero] = '-';
                        Colhero--;
                        gameField[rowHero, Colhero] = 'f';
                        continue;
                    }

                    if (gameField[rowHero, Colhero - 1] == 'B')
                    {
                        // sam thing position re index of array
                        if (Colhero - 2 <= 0)
                        {
                            gameField[rowHero, Colhero] = '-';
                            Colhero = gameField.GetLength(1) - 1;
                            gameField[rowHero, Colhero] = 'f';
                        }
                        else if (Colhero - 2 > 0)
                        {
                            gameField[rowHero, Colhero] = '-';
                            Colhero -= 2;
                            gameField[rowHero, Colhero] = 'f';
                        }

                    }

                    if (gameField[rowHero, Colhero - 1] == 'F')
                    {
                        isEnd = true;
                        gameField[rowHero, Colhero] = '-';
                        gameField[rowHero, Colhero - 1] = 'f';
                        break;
                    }
                    if (Colhero - 1 < 0)
                    {
                        gameField[rowHero, Colhero] = '-';
                        Colhero = gameField.GetLength(1) - 1;
                        gameField[rowHero, Colhero] = 'f';
                    }
                }

                if (position == "right")
                {
                    if (gameField[rowHero, Colhero + 1] == 'T')
                    {
                        continue;
                    }

                    if (gameField[rowHero, Colhero + 1] == 'B')
                    {
                        gameField[rowHero, Colhero] = '-';
                        Colhero += 2;
                        gameField[rowHero, Colhero] = 'f';
                    }

                    if (gameField[rowHero, Colhero + 1] == 'F')
                    {
                        isEnd = true;
                        gameField[rowHero, Colhero] = '-';
                        gameField[rowHero, Colhero + 1] = 'f';
                        break;
                    }
                    if (Colhero + 1 > gameField.GetLength(1) - 1)
                    {
                        gameField[rowHero, Colhero] = '-';
                        Colhero = 0;
                        gameField[rowHero, Colhero] = 'f';
                    }
                    else if (gameField[rowHero, Colhero + 1] != 'B' && gameField[rowHero, Colhero + 1] != 'T'
                             && gameField[rowHero, Colhero + 1] != 'F')
                    {
                        gameField[rowHero, Colhero] = '-';
                        Colhero++;
                        gameField[rowHero, Colhero] = 'f';
                    }
                }

            }

            if (isEnd)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatrix(gameField);

        }

        private static void PrintMatrix(char[,] gameField)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
