using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            int[] secondorders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(secondorders);
            int max = orders.Max();
            int sum = 0;
            while (orders.Count > 0)
            {
                int all = orders.Peek();
                sum += all;
                if (sum <= food)
                {
                    orders.Dequeue();
                }
                else
                {
                    foreach (var itemOrder in orders)
                    {
                        Console.WriteLine(max);
                        Console.WriteLine($"Orders left: {itemOrder}");
                        return;
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine($"Orders complete");





            // int foodQuantity = int.Parse(Console.ReadLine());
            //
            // int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //
            // var myQ = new Queue<int>(orders);
            //
            // int sum = 0;
            //
            // Console.WriteLine(myQ.Max());
            //
            // while (myQ.Count > 0)
            // {
            //     int first = myQ.Peek();
            //
            //     sum += first;
            //
            //     if (sum <= foodQuantity)
            //     {
            //         myQ.Dequeue();
            //     }
            //     else
            //     {
            //         int[] arr = myQ.ToArray();
            //         Console.WriteLine("Orders left: " + string.Join(" ", arr));
            //         return;
            //     }
            // }
            //
            // Console.WriteLine("Orders complete");
        }
    }
}
