using System;

namespace GenericBoxofString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var boxes = new Box<int>(input);
                Console.WriteLine(boxes.ToString());
            }

            // Task 1-2
        }
    }
}
