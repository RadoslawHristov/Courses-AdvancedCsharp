using System;
using System.IO;

namespace StreamsFile
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("input.txt"))
            {

                string input = reader.ReadLine();
                int indexofLine = 1;

                while (input != null)
                {
                    Console.WriteLine($"{indexofLine}. {input}");
                    indexofLine++;
                    input = reader.ReadLine();
                }
            }
        }
    }
}
