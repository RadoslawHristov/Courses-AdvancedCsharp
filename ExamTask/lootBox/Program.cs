using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLot = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondLot = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int itemColections = 0;


            while (firstLot.Count > 0 && secondLot.Count > 0)
            {
                int curentFir = firstLot.Peek();
                int curentSec = secondLot.Peek();

                int sum = curentFir + curentSec;

                if (sum % 2 == 0)
                {
                    itemColections += sum;
                    firstLot.Dequeue();
                    secondLot.Pop();
                }
                else
                {
                    firstLot.Enqueue(curentSec);
                    secondLot.Pop();
                }
            }

            if (firstLot.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondLot.Count==0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (itemColections >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {itemColections}");
            }
            else if (itemColections < 100)
            {
                Console.WriteLine($"Your loot was poor... Value: {itemColections}");
            }
        }
    }
}
