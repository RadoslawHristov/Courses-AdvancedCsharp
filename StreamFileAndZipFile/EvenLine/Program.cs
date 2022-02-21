using System;
using System.IO;
using System.Text;

namespace Even_Line_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Odd lines - ");
            var resultedOddLines = new StringBuilder();
            var file = "../../ReadFile.txt";

            using (var reader = new StreamReader(file))
            {
                var lineNumber = 0;
                var line = reader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        resultedOddLines.Append($"{line}{Environment.NewLine}");
                    }

                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}