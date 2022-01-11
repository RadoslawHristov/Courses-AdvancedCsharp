using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> simbol = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (!simbol.ContainsKey(ch))
                {
                    simbol.Add(ch,0);
                }

                simbol[ch] += 1;
            }

            foreach (var item in simbol.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
