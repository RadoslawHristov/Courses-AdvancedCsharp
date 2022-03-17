using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList random = new RandomList();
            random.Add("1");
            random.Add("2");
            random.Add("3");
            random.Add("5");
            random.Add("6");
            random.Add("7");
            random.Add("8");

            Console.WriteLine(random.RandomString());
            
        }
    }
}
