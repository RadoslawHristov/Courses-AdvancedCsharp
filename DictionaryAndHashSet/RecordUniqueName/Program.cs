using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> name = new HashSet<string>();


            for (int i = 0; i < count; i++)
            {
                string names = Console.ReadLine();
                name.Add(names);
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
