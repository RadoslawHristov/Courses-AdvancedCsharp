using System;
using System.Collections.Generic;

namespace _06._Parking_Lot_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> idCars = new HashSet<string>();

            while (input != "END")
            {
                string[] comand = input.Split(",");
                string action = comand[0];
                string id = comand[1];
                if (action == "IN")
                {
                    idCars.Add(id);
                }

                if (action == "OUT")
                {
                    idCars.Remove(id);
                }
                input = Console.ReadLine();
            }

            if (idCars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in idCars)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
