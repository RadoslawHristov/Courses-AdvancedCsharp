using System;

namespace Sarvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] beach = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] curentLine = Console.ReadLine().Replace(" ", "").ToCharArray();

                beach[i] = curentLine;
            }

            string input = Console.ReadLine();

            int mycoins = 0;
            int oponentcoins = 0;

            while (input != "Gong")
            {

                string[] splited = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string comand = splited[0];

                if (comand == "Find")
                {
                    int row = int.Parse(splited[1]);
                    int col = int.Parse(splited[2]);
                    if (isValid(row, col, beach))
                    {
                        if (beach[row][col] == 'T')
                        {
                            mycoins++;
                            beach[row][col] = '-';
                        }
                    }
                }
                else if (comand == "Opponent")
                {
                    int row = int.Parse(splited[1]);
                    int col = int.Parse(splited[2]);
                    string position = splited[3];

                    if (isValid(row, col, beach))
                    {

                        if (beach[row][col] == 'T')
                        {
                            oponentcoins++;
                            beach[row][col] = '-';
                        }

                        for (int i = 1; i <= 3; i++)
                        {
                            if (position == "up")
                            {
                                row--;
                                if (isValid(row, col, beach))
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentcoins++;
                                        beach[row][col] = '-';
                                    }
                                }
                            }
                            else if (position == "down")
                            {
                                row++;
                                if (isValid(row, col, beach))
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentcoins++;
                                        beach[row][col] = '-';
                                    }
                                }
                            }
                            else if (position == "left")
                            {
                                col--;
                                if (isValid(row, col, beach))
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentcoins++;
                                        beach[row][col] = '-';
                                    }
                                }

                            }
                            else if (position == "right")
                            {
                                col++;
                                if (isValid(row, col, beach))
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentcoins++;
                                        beach[row][col] = '-';
                                    }
                                }

                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in beach)
            {
                var curent = string.Join(" ", item);
                Console.WriteLine(curent);
            }

            Console.WriteLine($"Collected tokens: {mycoins}");
            Console.WriteLine($"Opponent's tokens: {oponentcoins}");
        }

        private static bool isValid(int row, int col, char[][] beach)
        {
            bool isValid = false;
            if (row >= 0 && row <= beach.Length && col >= 0 && col <= beach[row].Length-1)
            {
                return isValid = true;
            }

            return isValid;
        }
    }
}
