using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family one = new Family();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] nameAndAge = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                Person person = new Person(name, age);

                one.AddMember(person);
            }

            one.GetOldestMember();
           
        }
    }
}
