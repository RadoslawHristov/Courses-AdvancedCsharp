using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));


            int colection = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {

                int curentFirstBox = firstBox.Peek();
                int curentSecondBox = secondBox.Peek();

                int curentResult = curentFirstBox + curentSecondBox;

                if (curentResult % 2==0)
                {
                    colection += curentResult;
                    curentFirstBox = firstBox.Dequeue();
                    curentSecondBox = secondBox.Pop();
                }
                else if (curentResult % 2==1)
                {
                    firstBox.Enqueue(curentSecondBox);
                    secondBox.Pop();
                }
            }

            if (firstBox.Count==0)
            {
                Console.WriteLine("First lootbox is empty"); 
            }
            else if (secondBox.Count==0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (colection >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {colection}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {colection}");
            }
        }
    }
}
