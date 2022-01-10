using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> citizen =
                new Dictionary<string, Dictionary<string, List<string>>>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string citizens = input[0];
                string country = input[1];
                string city = input[2];

                if (!citizen.ContainsKey(citizens))
                {
                    citizen.Add(citizens, new Dictionary<string, List<string>>());
                }

                if (!citizen[citizens].ContainsKey(country))
                {
                    citizen[citizens][country] = new List<string>();
                }
                citizen[citizens][country].Add(city);
            }

            foreach (var continentCountries in citizen)
            {
                var continentName = continentCountries.Key;
                Console.WriteLine($"{continentName}:");
                foreach (var countryCities in continentCountries.Value)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine($"{countryName} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
