using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] numberVowels = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();
            char[] numberConsonants = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();

            Queue<char> vowels = new Queue<char>(numberVowels);
            Stack<char> consonants = new Stack<char>(numberConsonants);

            List<char> letters = new List<char>();
            List<string> foundWords = new List<string>();

            while (consonants.Count > 0)
            {
                char currentVowel = vowels.Dequeue();
                vowels.Enqueue(currentVowel);
                char currentConsonant = consonants.Pop();

                letters.Add(currentVowel);
                letters.Add(currentConsonant);
            }

            List<string> words = new List<string> { "pear", "flour", "pork", "olive" };
            for (int i = 0; i < words.Count; i++)
            {
                List<char> currentWord = new List<char>(words[i]);

                foreach (var letter in letters)
                {
                    if (currentWord.Contains(letter))
                    {
                        currentWord.Remove(letter);
                    }
                }

                if (currentWord.Count == 0)
                {
                    foundWords.Add(words[i]);
                }
            }

            Console.WriteLine($"Words found: {foundWords.Count}");
            foreach (var word in foundWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}

