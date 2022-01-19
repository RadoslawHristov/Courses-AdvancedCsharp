using System;

namespace DefiningClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier date = new DateModifier();
            int result=date.DaysCalculateTwoDate(firstDate, secondDate);
            Console.WriteLine(Math.Abs(result));
        }
    }
}
