using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _10._Predicate_Party__Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> NameOfParty = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            
            while (input != "Party!")
            {
                string[] splitedComand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Predicate<string> predicat = GetGoing(splitedComand[1],splitedComand[2]);

                if (splitedComand[0]=="Remove")
                {
                    NameOfParty.RemoveAll(predicat);
                }
                else if (splitedComand[0]=="Double")
                {
                    List<string> allNmaes = NameOfParty.FindAll(predicat);
                    if (allNmaes.Any())
                    {
                        int index = NameOfParty.FindIndex(predicat);
                        NameOfParty.InsertRange(index,allNmaes);

                    }
                }
                input = Console.ReadLine();
            }

            if (NameOfParty.Any())
            {
                Console.WriteLine($"{string.Join(", ",NameOfParty)} are going to the party!"); }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetGoing(string s,string comand)
        {
            if (s== "StartsWith")
            {
                return x => x.StartsWith(comand);
            }
            else if (s== "EndsWith")
            {
                return x => x.EndsWith(comand);
            }

            int lenght = int.Parse(comand);
            return x => x.Length == lenght;
        }
    }
}
