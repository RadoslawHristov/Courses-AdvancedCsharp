using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfComand = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> Continent =
                new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < countOfComand; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!Continent.ContainsKey(continent))
                {
                    Continent.Add(continent,new Dictionary<string, List<string>>());
                }
                if (!Continent[continent].ContainsKey(country))
                {
                    Continent[continent].Add(country,new List<string>());
                }
                Continent[continent][country].Add(city);
            }

            foreach (var  continent in Continent)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var item in continent.Value)
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
