using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace _03._Product_Shop_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,double>> MagFruit = new Dictionary<string, Dictionary<string,double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] splited = input.Split(", ");
                string foodshop = splited[0];
                string food = splited[1];
                double price = double.Parse(splited[2]);

                if (!MagFruit.ContainsKey(foodshop))
                {
                    MagFruit.Add(foodshop,new Dictionary<string, double>());
                }
                MagFruit[foodshop].Add(food,price);
                input = Console.ReadLine();
            }

            var result = MagFruit.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var sv in item.Value)
                {
                    double res = sv.Value;
                    Console.WriteLine($"Product: {sv.Key}, Price: {res}");
                }
            }
           
        }
    }
}
