using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person per = new Person(default, default);
            Console.WriteLine($"{per.Name} {per.Age}");
        }
    }
}
