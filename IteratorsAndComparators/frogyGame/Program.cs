using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();

            Lake<int> com = new Lake<int>();
            com.Add(input);

            Console.WriteLine(string.Join(", ",com));

            //foreach (var item in com)
            //{
            //    Console.Write(item+","+" ");
            //}
        }
    }
}
