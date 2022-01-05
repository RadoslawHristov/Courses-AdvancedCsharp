using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> reservationList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var directionary = new Dictionary<string, Predicate<string>>();


            string comand = Console.ReadLine();

            while (comand != "Print")
            {
                string[] splited = comand.Split(";");
                string action = splited[0];
                string predicate = splited[1];
                string value = splited[2];
                string key = predicate + "_" + value;
                if (splited[0]=="Add filter")
                {
                    
                    Predicate<string> get = GetGoing(predicate, value);
                    directionary.Add(key,get);
                }
                else if (splited[0]== "Remove filter")
                {
                    directionary.Remove(key);
                }

                comand = Console.ReadLine();
            }

            foreach (var(key,predicate) in directionary)
            {
                reservationList.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ",reservationList));
        }
        private static Predicate<string> GetGoing(string s, string comand)
        {
            if (s == "Starts with")
            {
                return x => x.StartsWith(comand);
            }
            else if (s == "Ends with")
            {
                return x => x.EndsWith(comand);
            }
            else if (s=="Contains")
            {
                return x => x.Contains(comand);
            }


            int lenght = int.Parse(comand);
            return x => x.Length == lenght;
        }
    }
}
