using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private  ICollection<Fish> fish;
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            fish = new List<Fish>();
        }
       
        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count => this.fish.Count;
        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)this.fish;


        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || string.IsNullOrEmpty(fish.FishType)|| fish.Length <= 0 || fish.Weight <= 0)
            {
                return $"Invalid fish.";
            }

            if (this.fish.Count+1 >=this.Capacity )
            {
                return $"Fishing net is full.";
            }

            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            var fish = Fish.FirstOrDefault(x => x.Weight == weight);
            if (fish!=null)
            {
               return this.fish.Remove(fish);
               
            }
            else
            {
                return false;
            }
        }

        public Fish GetFish(string fishType)
        {
            var curentFish = this.fish.FirstOrDefault(x => x.FishType == fishType);
            return curentFish;
        }

        public Fish GetBiggestFish()
        {
            var bigLenght = this.fish.Max(x => x.Length);
            var fish = this.fish.FirstOrDefault(x => x.Length==bigLenght);
            return fish;
        }

        public string Report()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"Into the {this.Material}:");
            foreach (var fish in Fish.OrderByDescending(x=>x.Length))
            {
                sv.AppendLine(fish.ToString());
            }

            return sv.ToString().TrimEnd();
        }
    }
}
