using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            List<Engine> engin = new List<Engine>();
            Car car = null;
            Engine engine = null;

            for (int i = 0; i < engineCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                GetInicialiseEngine(input, engine,engin);
            }

            int countCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCar; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                GetInstanceCar(input,car,cars,engin);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void GetInstanceCar(string[] input, Car car, List<Car> cars,List<Engine>engines)
        {
            if (input.Length == 2)
            {
                string model = input[0];
                string engin = input[1];
                var engine = engines.Where(x => x.Model == engin).First();
                car = new Car(model,engine);
                cars.Add(car);
            }
            else if (input.Length == 3)
            {
                string model = input[0];
                string engine = input[1];
                var engin = engines.Where(x => x.Model == engine).First();
                var weight = 0;
                int.TryParse(input[2], out weight);
                if (weight !=0)
                {
                    weight = int.Parse(input[2]);
                    car = new Car(model, engin, weight);
                }
                else
                {
                    string color = input[2];
                    car = new Car(model, engin, color);
                }
               
                cars.Add(car);
            }
            else if (input.Length == 4)
            {
                string model = input[0];
                string engine = input[1];
                var engin = engines.Where(x => x.Model == engine).First();
                int weight = int.Parse(input[2]);
                string color = input[3];
                car = new Car(model, engin, weight, color);
                cars.Add(car);
            }
        }

        private static void GetInicialiseEngine(string[] input, Engine engine,List<Engine> engin)
        {
            if (input.Length==2)
            {
                string model = input[0];
                int power = int.Parse(input[1]);
                engine = new Engine(model, power);
                engin.Add(engine);
            }
            else if (input.Length==3)
            {
                string model = input[0];
                int power = int.Parse(input[1]);
                int displacement = 0;
                int.TryParse(input[2], out displacement);
                if (displacement !=0)
                {
                    engine = new Engine(model, power,displacement);
                }
                else
                {
                    string efficiency = input[2];
                    engine = new Engine(model, power, efficiency);
                }
                
                engin.Add(engine);
            }
            else if (input.Length==4)
            {
                string model = input[0];
                int power = int.Parse(input[1]);
                int displacement = int.Parse(input[2]);
                string efficiency = input[3];
                engine = new Engine(model, power, displacement,efficiency);
                engin.Add(engine);
            }
        }
    }
}
