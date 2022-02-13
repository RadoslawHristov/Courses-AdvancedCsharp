using System;
using System.Linq;

namespace _4._Matrix_Shuffling_Exs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            string[][] matrix = new string[rows][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                matrix[i] = input;
            }

            string comand = Console.ReadLine();

            while (comand != "END")
            {
                string[] splited = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = splited[0];

                string secondElement = String.Empty;
                string firstElement = String.Empty;
                bool isValidindex = false;

                if (splited.Length == 5 && action == "swap")
                {
                    int firstRow = int.Parse(splited[1]);
                    int firstCol = int.Parse(splited[2]);
                    int secondRow = int.Parse(splited[3]);
                    int secondCol = int.Parse(splited[4]);



                    if (firstRow <= matrix.Length - 1 && firstRow >= 0 && firstCol >= 0
                    && firstCol <= matrix[firstRow].Length - 1 && secondRow >= 0 && secondRow <= matrix.Length - 1
                    && secondCol >= 0 && secondCol <= matrix[secondRow].Length - 1)
                    {
                        firstElement = matrix[firstRow][firstCol];
                        secondElement = matrix[secondRow][secondCol];
                        isValidindex = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }


                    if (isValidindex)
                    {
                        string temp = firstElement;
                        matrix[firstRow][firstCol] = secondElement;
                        matrix[secondRow][secondCol] = temp;

                        for (int i = 0; i < matrix.Length; i++)
                        {
                            Console.WriteLine(String.Join(" ", matrix[i]));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                comand = Console.ReadLine();
            }

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //     Console.WriteLine(String.Join(" ", matrix[i]));
            //}
           
        }
    }
}
