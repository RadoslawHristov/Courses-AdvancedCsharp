using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var element = new Box<double>();

            for (int i = 0; i < count; i++)
            {
                double input =double.Parse(Console.ReadLine());

                element.AddElement(input);
            }

            double valuesElement = double.Parse(Console.ReadLine());
            Console.WriteLine(element.GetCount(valuesElement));

            // 03. Generic Swap Method String
            // 04. Generic Swap Method Integer
            // 05. Generic Count Method String
            // 06. Generic Count Method Double


        }
    }
}