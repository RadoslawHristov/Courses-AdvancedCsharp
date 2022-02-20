using System;
using System.Collections.Generic;
using System.IO;

namespace SlicingFile
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Slice(@"../../file.png", @"../../", 3);
            Assemble(new List<string>() { @"..\..\part1.png", @"..\..\part2.png", @"..\..\part3.png" }, @"..\..\");
        }

        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            var buffer = new byte[4096];
            using (var fileReader = new FileStream(sourceFile, FileMode.Open))
            {
                var lenght = fileReader.Length;
                long partSize = (long)Math.Ceiling((double)lenght / parts);

                for (int i = 1; i <= parts; i++)
                {

                    using (var fileWriter = new FileStream(destinationDirectory + "part" + i + ".png", FileMode.Create))
                    {

                        int number = fileReader.Read(buffer, 0, buffer.Length);
                        //var transferred = 0;
                        while (number != 0 && fileWriter.Length <= partSize)
                        {
                            fileWriter.Write(buffer, 0, number);

                            number = fileReader.Read(buffer, 0, buffer.Length);

                            Console.WriteLine(fileWriter.Length);

                        }
                        Console.WriteLine("Next");
                    }

                }
            }
        }

        public static void Assemble(List<string> files, string destinationDirectory)
        {
            var buffer = new byte[4096];
            using (var assembeled = new FileStream(destinationDirectory + "assembled.png", FileMode.Create))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    using (var reader = new FileStream(files[i], FileMode.Open))
                    {
                        int number = reader.Read(buffer, 0, buffer.Length);
                        while (number != 0)
                        {
                            assembeled.Write(buffer, 0, number);
                            number = reader.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}
