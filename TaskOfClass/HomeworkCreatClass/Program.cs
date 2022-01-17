using System;
using CarManufacturer;

namespace _1_Car_Lab
{
    public class StartUp
    {
        static void Main(string[] args)
        { 
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
