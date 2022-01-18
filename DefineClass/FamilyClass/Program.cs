using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split();

                string name = people[0];
                int age = int.Parse(people[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }
            var sorted = Family.People.Where(x => x.Age > 30).OrderBy(x => x.Name);
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
