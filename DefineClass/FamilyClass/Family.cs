using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace DefiningClasses
{
    public class Family
    {
        public static List<Person> People { get; set; }

        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = People.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;
        }

    }
}
