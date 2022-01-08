using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Even_Line
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        private static void ZipandExtract()
        {
            
            ZipFile.CreateFromDirectory("../../../", @"C:\Users\Radko\Desktop\result.zip");
        }

        private static void DirectoryTraversal()
        {
            string[] allFiles = Directory.GetFiles("../../../", ".");

            Dictionary<string, Dictionary<string, double>> directory = new Dictionary<string, Dictionary<string, double>>();

            foreach (var item in allFiles)
            {
                FileInfo size = new FileInfo(item);
                if (!directory.ContainsKey(size.Extension))
                {
                    directory.Add(size.Extension, new Dictionary<string, double>());
                }
                directory[size.Extension].Add(size.Name, size.Length);
            }

            var sorted = directory
                .OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);
            List<string> result = new List<string>();
            foreach (var item in directory)
            {
                result.Add($"{item.Key}");

                foreach (var file in item.Value.OrderBy(x=>x))
                {
                    result.Add($"--{file.Key} - {file.Value:f3}kb");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report";

            File.WriteAllLines("path", result);
        }

        private static void CopyBinaryFile()
        {
            using FileStream read = new FileStream(@"../../../CopyMe.png", FileMode.Open);
            using FileStream copy = new FileStream("CopyMycopy.png", FileMode.Create);
            byte[] curent = new byte[256];
            while (true)
            {
                int reads = read.Read(curent, 0, curent.Length);
                if (reads == 0)
                {
                    break;
                }
                copy.Write(curent, 0, curent.Length);
            }
        }

        public static void WordCount()
        {
            Dictionary<string, int> wordAndFrequency = new Dictionary<string, int>();
            string[] words = File.ReadAllText("../../../words.txt").Split();

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    string[] wordsInCurrentLine = currentLine.ToLower()
                        .Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        foreach (var item in wordsInCurrentLine)
                        {
                            if (word == item)
                            {
                                if (wordAndFrequency.ContainsKey(item) == false)
                                {
                                    wordAndFrequency.Add(item, 0);
                                }

                                wordAndFrequency[item]++;
                            }
                        }
                    }

                    currentLine = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter("actualResult.txt"))
            {
                foreach (var item in wordAndFrequency.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }

            }

        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                var countOfLetters = lines[i].Count(simbol => char.IsLetter(simbol));
                var countOfPunctuation = lines[i].Count(simbol => char.IsPunctuation(simbol));

                File.AppendAllText(@"../../../output.txt",
                    $"Line {i + 1}: {lines[i]} ({countOfLetters})({countOfPunctuation}){Environment.NewLine}");

            }
        }

        private static void EvenLines()
        {
            var reader = new StreamReader("text.txt");
            string[] simbols = { "-", "new[] , ", ".", "!", "?" };
            bool isEven = true;
            while (true)
            {
                var result = reader.ReadLine();
                if (result == null)
                {
                    break;
                }

                if (!isEven)
                {
                    isEven = true;
                    continue;
                }

                foreach (var simbol in simbols)
                {
                    result = result.Replace(simbol, "@");
                }

                Console.WriteLine(string.Join(" ", result.Split().Reverse()));

                isEven = false;
            }
        }
    }
}

