using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds_exersice
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> allnumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int first = allnumber[0];
            int second = allnumber[1];

            string comand = Console.ReadLine();

            List<int> contain = new List<int>();

            Predicate<int> evens = x=>
            {
                return x % 2 == 0;
            };
            Predicate<int> odd = x =>
            {
                return x % 2 != 0;
            };
            List<int> result = new List<int>();

            for (int i = first; i <=second ; i++)
            {
                contain.Add(i);
            }

            if (comand=="even")
            {
                result = contain.FindAll(evens);
            }
            else if (comand=="odd")
            {
                result = contain.FindAll(odd);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
