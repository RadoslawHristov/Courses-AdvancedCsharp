using System;
using System.Collections.Generic;

namespace Unique_Usernames_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int countName = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < countName; i++)
            {
                string username = Console.ReadLine();
                userNames.Add(username);
            }

            foreach (var item in userNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
