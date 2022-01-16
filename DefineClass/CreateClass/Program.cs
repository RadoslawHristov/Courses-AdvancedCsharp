using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] splitedInput = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string trainerName = splitedInput[0];
                string pokemonName = splitedInput[1];
                string element = splitedInput[2];
                int pokemonHealth = int.Parse(splitedInput[3]);


                if (!trainers.ContainsKey(trainerName))
                {
                    var newTrainer = new Trainer(trainerName);

                    trainers.Add(trainerName, newTrainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, element, pokemonHealth);

                var train = trainers[trainerName];
                train.Pokemons.Add(pokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var item in trainers)
                {
                    if (item.Value.Pokemons.Any(x=>x.Element == input))
                    {
                        item.Value.Badges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in item.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        item.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in trainers.OrderByDescending(x=>x.Value.Badges))
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
