using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> NameAndGrade = new Dictionary<string, List<decimal>>();

            int countOfStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfStudent; i++)
            {
                string[] nameAndGra = Console.ReadLine().Split();
                string name = nameAndGra[0];
                decimal grade = decimal.Parse(nameAndGra[1]);

                if (NameAndGrade.ContainsKey(name))
                {
                    NameAndGrade[name].Add(grade);
                }
                if (!NameAndGrade.ContainsKey(name))
                {
                    NameAndGrade.Add(name,new List<decimal>());
                    NameAndGrade[name].Add(grade);
                }
            }

            foreach (var item in NameAndGrade)
            {
                Console.Write($"{item.Key} -> ");
                var avg = item.Value;
                foreach (var sv in item.Value)
                {
                    Console.Write($"{sv:f2} ");
                }
                Console.WriteLine($"(avg: {avg.Average():f2})");
            }
        }
    }
}
