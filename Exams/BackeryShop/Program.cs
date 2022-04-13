using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> BackersAndCount = new Dictionary<string, int>()
            {
                {"Croissant",0},
                {"Muffin",0},
                {"Baguette",0},
                {"Bagel",0}
            };

            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));

            

            while (water.Any() && flour.Any())
            {
                double curentWater = water.Peek();
                double curentFlour = flour.Peek();

                double sumWaterAndFlour = curentWater + curentFlour;

                double watterProcent = (curentWater * 100) / sumWaterAndFlour;
                double flourProcent = (curentFlour * 100) / sumWaterAndFlour;

                if (GetMuffin(watterProcent, flourProcent))
                {
                    water.Dequeue();
                    flour.Pop();
                    BackersAndCount["Muffin"]++;
                }
                else if (GetCroissant(watterProcent, flourProcent))
                {
                    water.Dequeue();
                    flour.Pop();
                    BackersAndCount["Croissant"]++;
                }
                else  if (GetBaguette(watterProcent, flourProcent))
                {
                    water.Dequeue();
                    flour.Pop();
                    BackersAndCount["Baguette"]++;
                }
                else if (GetBagel(watterProcent,flourProcent))
                {
                    water.Dequeue();
                    flour.Pop();
                    BackersAndCount["Bagel"]++;
                }
                else
                {
                    var currentFlowerr = flour.Pop();
                    var currentWater = water.Dequeue();       
                    var flourReduced = currentFlowerr - currentWater;
                    BackersAndCount["Croissant"]++;
                    flour.Push(flourReduced);
                }
            }

            foreach (var item in BackersAndCount.OrderByDescending(x=>x.Value)
                         .ThenBy(x=>x.Key))
            {
                if (item.Value > 0)
                {
                     Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            var flourLeft = flour.Count == 0 ? "None" : string.Join(", ", flour);
            var waterLeft = water.Count == 0 ? "None" : string.Join(", ", water);

            Console.WriteLine($"Water left: {waterLeft}");
            Console.WriteLine($"Flour left: {flourLeft}");

            //if (water.Count==0)
            //{
            //    Console.WriteLine("Water left: None");
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(", ",$"Water left: {water}"));
            //}
            //
            //if (flour.Count==0)
            //{
            //    Console.WriteLine("Flour left: None");
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(", ",$"Flour left: {flour.Pop()}"));
            //}
        }

        private static bool GetBagel(double watterProcent, double flourProcent)
        {
            if (watterProcent==20 && flourProcent==80)
            {
                return true;
            }

            return false;
        }

        private static bool GetBaguette(double watterProcent, double flourProcent)
        {
            if (watterProcent == 30 && flourProcent == 70)
            {
                return true;
            }

            return false;
        }
        private static bool GetCroissant(double watterProcent, double flourProcent)
        {
            if (watterProcent == 50 && flourProcent == 50)
            {
                return true;
            }

            return false;
        }
        private static bool GetMuffin(double watterProcent, double flourProcent)
        {
            if (watterProcent == 40 && flourProcent == 60)
            {
                return true;
            }

            return false;
        }
    }
}
