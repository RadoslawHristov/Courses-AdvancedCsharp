using System;
using System.Linq;

namespace _6._Jagged_Array_Modification_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jugged = new int[rows][];

            for (int row = 0; row < jugged.Length; row++)
            {
                int[] input = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();
                jugged[row] = input;
            }

            string comand = Console.ReadLine();

            while (comand != "END")
            {
                string[] information = comand.Split();
                if (information[0] == "Add")
                {
                    int row = int.Parse(information[1]);
                    int col = int.Parse(information[2]);
                    int value = int.Parse(information[3]);
                    if (row < 0 || row > jugged.Length-1 || col < 0 || col > jugged[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jugged[row][col] += value;
                        
                    }
                }
                else if (information[0] == "Subtract")
                {
                    int row = int.Parse(information[1]);
                    int col = int.Parse(information[2]);
                    int value = int.Parse(information[3]);
                    if (row < 0 || row > jugged.Length-1 || col < 0 || col >= jugged[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jugged[row][col] -= value;
                    }
                }
                comand = Console.ReadLine();
            }
            for (int i = 0; i < jugged.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jugged[i]));
            }
        }
    }
}
