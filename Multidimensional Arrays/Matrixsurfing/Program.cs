using System;

using System.Linq;

namespace _4._Matrix_Shuffling_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int first = size[0];
            int second = size[1];
            

            string[,] comandArray = new string[size[0], size[1]];

            for (int row = 0; row < comandArray.GetLength(0); row++)
            {
                string[] matrixInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < comandArray.GetLength(1); col++)
                {
                    comandArray[row, col] = matrixInput[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (first <= 0 || second <= 0)
                {
                    break;
                }

                
                string[] comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (comand.Length < 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (comand[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                string action = comand[0];
                long row1 = long.Parse(comand[1]);
                long colIndex = long.Parse(comand[2]);
                long rowtarget = long.Parse(comand[3]);
                long colTarget = long.Parse(comand[4]);

                if (action == "swap")
                {
                    if (row1 >= 0 && row1 <= comandArray.Length && colIndex >= 0 && colIndex <= comandArray.Length
                    && rowtarget >= 0 && rowtarget <= comandArray.Length && colTarget >= 0 && colTarget <= comandArray.Length)
                    {
                        string temp = comandArray[row1, colIndex];
                        comandArray[row1, colIndex] = comandArray[rowtarget, colTarget];
                        comandArray[rowtarget, colTarget] = temp;
                        PrintMatrix(comandArray);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }
        }

        public static void PrintMatrix(string[,] comandArray)
        {
            for (int row = 0; row < comandArray.GetLength(0); row++)
            {
                for (int col = 0; col < comandArray.GetLength(1); col++)
                {
                    Console.Write(comandArray[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
