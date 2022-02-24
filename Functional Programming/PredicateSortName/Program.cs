using System;
using System.Collections.Generic;

namespace _07._Predicate_For_Names_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfstring = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            string[] name = Console.ReadLine()
                .Split();

            Func<string, bool> namesLenght = x => x.Length <= lenghtOfstring;
            for (int i = 0; i < name.Length; i++)
            {
                if (namesLenght(name[i]))
                {
                    names.Add(name[i]);
                }
            }

            Console.Write(String.Join(Environment.NewLine, names));

        }
    }
}
