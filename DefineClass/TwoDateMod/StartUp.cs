using System;

namespace TwoDateMod
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateTime date1 = DateTime.Parse(dateOne);
            DateTime date2 = DateTime.Parse(dateTwo);

            Date_Modifier data = new Date_Modifier(date1,date2);

            Console.WriteLine(data.GetDayForTwoDate());
            
        }
    }
}
