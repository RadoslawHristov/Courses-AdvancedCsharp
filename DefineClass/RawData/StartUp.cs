using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", 6);
                // "{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType}
                //{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age}
                //{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string model = input[0];
                int engSpeed = int.Parse(input[1]);
                int engPower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                var tires = new List<Tires>();
                var tier = input[5].Split(" ").ToArray();
                
                
                for (int j = 0; j < tier.Length; j+=2)
                {
                    Tires tire = null;
                    double plassure = double.Parse(tier[j]);
                    int year = int.Parse(tier[j+1]);
                    tire = new Tires(plassure, year);
                    tires.Add(tire);
                }
                


                Engine engine = new Engine(engSpeed, engPower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo, tires.ToArray());
                cars.Add(car);
            }

            string action = Console.ReadLine();

            switch (action)
            {
                case "fragile":
                    DisplayFragile(cars);
                    break;
                case "flammable":
                    DisplayFlamable(cars);
                    break;
            }
        }
        static void DisplayFragile(List<Car> cars)
        {
            foreach (var car in cars)
            {
                string model = string.Empty;
                foreach (var tire in car.Tires)
                {

                    if (tire.Pressure < 1 && car.Model != model)
                    {
                        model = car.Model;
                        Console.WriteLine($"{car.Model}");
                    }
                }

            }
        }
        static void DisplayFlamable(List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (car.Engine.Power > 250)
                    Console.WriteLine($"{car.Model}");
            }
        }

    }
}
