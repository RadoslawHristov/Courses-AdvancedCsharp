using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> wordAndCount = new Dictionary<char, int>();

            string inputWord = Console.ReadLine();

            for (int i = 0; i < inputWord.Length; i++)
            {
                char ch = inputWord[i];
                if (!wordAndCount.ContainsKey(ch))
                {
                    wordAndCount.Add(ch, 0);
                }

                wordAndCount[ch] += 1;
            }

            foreach (var word in wordAndCount.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{word.Key}: {word.Value} time/s");
            }
        }
    }
}
