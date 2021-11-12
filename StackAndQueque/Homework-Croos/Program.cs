using System;
using System.Collections.Generic;

namespace _10._Crossroads_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freewindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCar = 0;
            bool isHiteed = false;
            while (input != "END")
            {
                if (input == "green")
                {
                    int curentgreen = greenLight;
                    while (cars.Count > 0 && curentgreen > 0)
                    {
                        string curentCar = cars.Dequeue();
                        if (curentgreen-curentCar.Length >=0)
                        {
                            curentgreen -= curentCar.Length;
                            passedCar++;
                            continue;
                        }

                        if (curentgreen-freewindow-curentCar.Length >= 0)
                        {
                            curentgreen = 0;
                            passedCar++;
                            continue;
                        }

                        string hitted = curentCar.Substring(curentgreen + freewindow, 1);
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{curentCar} was hit at {hitted}.");
                        isHiteed = true;
                        Environment.Exit(0);
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            if (!isHiteed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCar} total cars passed the crossroads.");
            }

        }
    }
}
