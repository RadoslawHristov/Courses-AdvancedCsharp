using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Predicate<int> allNumber=null;

            string comand = Console.ReadLine().ToLower();
            if (comand=="odd")
            {
                allNumber = x => x % 2 != 0;
            }
            else if (comand=="even")
            {
                allNumber = x => x % 2 == 0;
            }

            for (int i = number[0]; i <= number[1]; i++)
            {
                if (allNumber(i))
                {
                    Console.Write(i+" ");
                }   
            }
        }
    }
}
