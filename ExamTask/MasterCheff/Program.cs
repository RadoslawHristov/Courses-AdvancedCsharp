using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> dish = new Queue<int>(Console.ReadLine()
                .Split(" ").Select(int.Parse));

            Stack<int> freshnesLevel = new Stack<int>(Console.ReadLine()
                .Split(" ").Select(int.Parse));

            Dictionary<string, int> CookingTable = new Dictionary<string, int>()
            {
                { "Dipping sauce", 0 },
                { "Green salad", 0 },
                { "Chocolate cake", 0 },
                { "Lobster", 0 }
            };

            int countOfCooking = 0;

            while (dish.Count > 0 && freshnesLevel.Count > 0)
            {
               
                if (dish.Peek()==0)
                {
                    dish.Dequeue();
                    continue;
                }


                int curentResult = dish.Peek() * freshnesLevel.Peek();

                if (curentResult == 150)
                {
                    CookingTable["Dipping sauce"] ++;
                    dish.Dequeue();
                    freshnesLevel.Pop();
                }
                else if (curentResult == 250)
                {
                    CookingTable["Green salad"] ++;
                    dish.Dequeue();
                    freshnesLevel.Pop();

                }
                else if (curentResult == 300)
                {
                    CookingTable["Chocolate cake"] ++;
                    dish.Dequeue();
                    freshnesLevel.Pop();
                }
                else if (curentResult == 400)
                {
                    CookingTable["Lobster"] ++;
                    dish.Dequeue();
                    freshnesLevel.Pop();
                }
                else
                {
                    freshnesLevel.Pop();
                    int curent=dish.Peek() + 5;
                    dish.Dequeue();
                    dish.Enqueue(curent);
                }
            }

            foreach (var item in CookingTable)
            {
                if (item.Value > 0)
                {
                    countOfCooking++;
                }
            }
            if (countOfCooking == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
            }

            if (dish.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {dish.Sum()}");
            }

            foreach (var item in CookingTable
                .OrderBy(x => x.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($" # {item.Key} --> {item.Value}");
                }
            }

        }// 100 / 100
    }
}
