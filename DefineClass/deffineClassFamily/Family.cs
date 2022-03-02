using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();

        }
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public void GetOldestMember()
        {
            foreach (var item in People.OrderBy(x=>x.Name))
            {
                if (item.Age > 30)
                {
                    Console.WriteLine( $"{item.Name} - {item.Age}");
                }
            }
        }
    }
}
