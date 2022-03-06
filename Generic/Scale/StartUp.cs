using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> num = new EqualityScale<int>(1, 1);

            Console.WriteLine(num.AreEqual());
            
        }
    }
}
