using System;
using System.Collections.Generic;
using System.Linq;

namespace foods
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowel = new Queue<char>(Console.ReadLine().Split().Select(char.Parse));
            Stack<char> agree = new Stack<char>(Console.ReadLine().Split().Select(char.Parse));

            List<char> curentChar = new List<char>();
            List<string> foundWord = new List<string>();

            while (agree.Count > 0)
            {
                char curentVowel = vowel.Dequeue();
                vowel.Enqueue(curentVowel);
                char curentagree = agree.Pop();
                curentChar.Add(curentVowel);
                curentChar.Add(curentagree);
            }

            List<string> word = new List<string>() { "pear", "flour", "pork", "olive" };

            for (int i = 0; i < word.Count; i++)
            {
                List<char> curendword = new List<char>(word[i]);

                foreach (var item in curentChar)
                {
                    if (curendword.Contains(item))
                    {
                        curendword.Remove(item);
                    }
                }

                if (curendword.Count==0)
                {
                    foundWord.Add(word[i]);
                }
            }
            Console.WriteLine($"Words found: {foundWord.Count}");
            foreach (var item in foundWord)
            {
                Console.WriteLine(item);
            }
        }
    }
}
