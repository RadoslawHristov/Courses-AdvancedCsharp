using System;

namespace Tuples
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] nameTown = Console.ReadLine().Split(" ");
            MyTuple<string, string> NamesAndTown = new MyTuple<string, string>($"{nameTown[0]} {nameTown[1]}", nameTown[2]);

            string[] nameBeer = Console.ReadLine().Split(" ", 2);
            string name = nameBeer[0];
            int beer = int.Parse(nameBeer[1]);
            MyTuple<string, int> NameandBeer = new MyTuple<string, int>(name, beer);


            string[] number = Console.ReadLine().Split(" ",2);
            int numInt = int.Parse(number[0]);
            double numDouble = double.Parse(number[1]);
            MyTuple<int, double> numbers = new MyTuple<int, double>(numInt, numDouble);

            Console.WriteLine(NamesAndTown);
            Console.WriteLine(NameandBeer);
            Console.WriteLine(numbers);
        }
    }
}
