using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            //if row and row+1 areEqual Lenght multiplay * 2, otherwise / 2;

            int countrow = int.Parse(Console.ReadLine());

            double[][] inputjagged = new double[countrow][];

            for (int i = 0; i < inputjagged.Length; i++)
            {
                double[] inputNumber = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                inputjagged[i] = inputNumber;
            }

            double[][] jagged = GetAnalisjagged(inputjagged);

            string comand = Console.ReadLine();

            while (comand !="End")
            {
                string[] splitedComand = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = splitedComand[0];

                if (action=="Add")
                {
                    int row = int.Parse(splitedComand[1]);
                    int col = int.Parse(splitedComand[2]);
                    int value = int.Parse(splitedComand[3]);

                    if (row >=0 && row <= jagged.Length-1 && col >=0 && col <= jagged[row].Length-1)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (action== "Subtract")
                {
                    int row = int.Parse(splitedComand[1]);
                    int col = int.Parse(splitedComand[2]);
                    int value = int.Parse(splitedComand[3]);

                    if (row>=0 && row <= jagged.Length && col >=0 && col <= jagged[row].Length-1)
                    {
                        jagged[row][col] -= value;
                    }
                }

                comand = Console.ReadLine();
            }
            

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(" ",inputjagged[i]));
            }
            
        }

        private static double[][] GetAnalisjagged(double[][] jagged)
        {
            for (int i = 0; i < jagged.Length - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = i; j <= i + 1; j++)
                    {
                        for (int k = 0; k < jagged[j].Length; k++)
                        {
                            jagged[j][k] *= 2;
                        }
                    }
                }
                else if (jagged[i].Length != jagged[i + 1].Length)
                {
                    for (int j = i; j <= i + 1; j++)
                    {
                        for (int k = 0; k <= jagged[j].Length - 1; k++)
                        {
                            jagged[j][k] /= 2;
                        }
                    }
                }
            }

            return jagged;
        }
    }
}
