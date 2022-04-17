using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        private  ICollection<Animal> Animals;

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.Animals = new List<Animal>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public IReadOnlyCollection<Animal> Animal => (IReadOnlyCollection<Animal>)this.Animals;

        public string AddAnimal(Animal animal)
        {
            if (Animal.Count + 1 == Capacity)
            {
                return "The zoo is full.";
            }

            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }

            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            this.Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int count = 0;

            var cur = Animals.Where(x => x.Species == species).ToList();
            for (int i = 0; i < cur.Count; i++)
            {
                Animals.Remove(cur[i]);
                count++;
            }
            return count;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            var animal = this.Animals.Where(x => x.Diet == diet).ToList();
            return animal;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            var curentAnimal = this.Animals.FirstOrDefault(x => x.Weight == weight);
            return curentAnimal;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (var animal in Animals)
            {
                if (animal.Length >= minimumLength && animal.Length <= maximumLength)
                {
                    count++;
                }
            }
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
