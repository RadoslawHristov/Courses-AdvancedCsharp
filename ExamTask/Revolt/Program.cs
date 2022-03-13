using System;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int comandcount = int.Parse(Console.ReadLine());

            char[,] field = new char[matrixSize,matrixSize];

            int heroRow = 0;
            int HeroCol = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                var inputLine = Console.ReadLine();

                for (int j = 0; j <field.GetLength(1); j++)
                {
                    field[i][j] = inputLine;
                }       
            }




        }

    }
}
