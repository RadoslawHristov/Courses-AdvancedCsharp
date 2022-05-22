using System;
using System.Collections.Generic;
using System.Linq;

namespace Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> dishes =
                new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<int> caloriesPerday =
                new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            //salad  soup   pasta  steak
            //350    490    680    790

            string curentDish = dishes.Peek();
            int curentCalories = caloriesPerday.Peek();
            int count = 0;

            while (dishes.Any() && caloriesPerday.Any())
            {
                if (curentCalories <= 0)
                {
                    caloriesPerday.Pop();
                    curentCalories = caloriesPerday.Peek();
                }
                if (curentDish == "salad" && curentCalories >= 350)
                {
                    curentCalories -= 350;
                    caloriesPerday.Pop();
                    caloriesPerday.Push(curentCalories);
                    dishes.Dequeue();
                    count++;
                    if (dishes.Count == 0)
                    {
                        break;
                    }
                    curentDish = dishes.Peek();
                }
                else if (curentDish == "soup" && curentCalories >= 490)
                {
                    curentCalories -= 490;
                    dishes.Dequeue();
                    caloriesPerday.Pop();
                    caloriesPerday.Push(curentCalories);
                    count++;
                    if (dishes.Count == 0)
                    {
                        break;
                    }
                    curentDish = dishes.Peek();
                }
                else if (curentDish == "pasta" && curentCalories >= 680)
                {
                    curentCalories -= 680;
                    dishes.Dequeue();
                    caloriesPerday.Pop();
                    caloriesPerday.Push(curentCalories);
                    count++;
                    if (dishes.Count == 0)
                    {
                        break;
                    }
                    curentDish = dishes.Peek();
                }
                else if (curentDish == "steak" && curentCalories >= 790)
                {
                    curentCalories -= 790;
                    dishes.Dequeue();
                    caloriesPerday.Pop();
                    caloriesPerday.Push(curentCalories);
                    count++;
                    if (dishes.Count==0)
                    {
                        break;
                    }
                    curentDish = dishes.Peek();
                }
                else
                {
                    // 310 stack 790
                    int oldCal = curentCalories;
                    caloriesPerday.Pop();
                    if (caloriesPerday.Count==0)
                    {
                        break;
                    }
                    curentCalories = caloriesPerday.Peek();
                    int sumCalories = oldCal + curentCalories;
                    caloriesPerday.Pop();
                    caloriesPerday.Push(sumCalories);
                    curentCalories = caloriesPerday.Peek();
                }
            }

            if (dishes.Count > 0)
            {
                Console.WriteLine($"John ate enough, he had {count+1} meals.");
                Console.Write("Meals left: ");
                Console.Write("pasta.");
            }
            else if (caloriesPerday.Count >0)
            {
                Console.WriteLine($"John had {count} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ",caloriesPerday)} calories.");
            }
        }
    }
}
