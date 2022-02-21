using System;
using System.IO;

namespace Copy_Binary_File_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Copy file - ");
            var inputFile = "../../iNPUTfILE.txt";
            var outputFile = "../../Coppyed";

            using (var reader = new FileStream(inputFile, FileMode.Open))
            {
                using (var writer = new FileStream(outputFile, FileMode.OpenOrCreate))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }

            Console.Write("Ready. Your file is here: ");
            //UserInterface.WriteGreen(outputFile);
        }
    }
}
