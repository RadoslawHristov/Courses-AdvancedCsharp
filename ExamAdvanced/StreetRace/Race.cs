using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public List<Car> Participants { get; set; }
        public int Count => Participants.Count;

        public void Add(Car car)
        {
            if (!Participants.Any(x => x.LicensePlate == car.LicensePlate) && Participants.Count + 1 <= Capacity
                                                             && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            var car = Participants.Where(x => x.LicensePlate == licensePlate).FirstOrDefault();
            if (car == null)
            {
                return false;
            }
            else
            {
                Participants.Remove(car);
                return true;
            }
        }

        public Car FindParticipant(string licensePlate)
        {
            var car = Participants.FirstOrDefault(x => x.LicensePlate == licensePlate);
            return car;
        }

        public Car GetMostPowerfulCar()
        {
            var car = Participants.OrderByDescending(x => x.HorsePower).FirstOrDefault();
            return car;
        }

        public string Report()
        {
            Console.WriteLine($"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})");
            StringBuilder sa = new StringBuilder();

            foreach (var itemCar in Participants)
            {
                sa.AppendLine(itemCar.ToString().TrimEnd());
            }

            return sa.ToString();
        }
    }
}
