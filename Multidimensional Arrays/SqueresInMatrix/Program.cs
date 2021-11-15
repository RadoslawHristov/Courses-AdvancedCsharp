using System;
using System.Linq;

namespace _2._Squares_in_Matrix_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (size.Length > 1)
            {
                char[,] sequens = new char[size[0],size[1]];
                for (int row = 0; row < sequens.GetLength(0); row++)
                {
                    char[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
                        .ToArray();

                    for (int col = 0; col < sequens.GetLength(1); col++)
                    {
                        sequens[row, col] = input[col];
                    }
                }

                int count = 0;
                for (int row = 0; row < sequens.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < sequens.GetLength(1) - 1; col++)
                    {
                        if (sequens[row, col] == sequens[row, col + 1] && sequens[row, col] == sequens[row + 1, col + 1]
                        && sequens[row,col]==sequens[row+1,col])
                        {
                            count++;
                        }
                    }
                }
                //A B B D
                //E B B B
                //I J B B
                Console.WriteLine(count);
            }
        }
    }
}
