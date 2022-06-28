using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> cars = new HashSet<string>();

            string command = Console.ReadLine();

            while (command.ToString() != "END")
            {
                string[] tokens = command.Split(", ");
                string direktion = tokens[0];
                string licencePlate = tokens[1];

                if (direktion == "IN")
                {
                    cars.Add(licencePlate);
                }
                else if (direktion.ToString() == "OUT")
                {
                    cars.Remove(licencePlate);
                }
                command = Console.ReadLine();
            }
            if (!cars.Any())
            {
                Console.WriteLine("Parking Lot is Empty");

            }
            else
            {
                foreach (var name in cars)
                {
                    Console.WriteLine(name);
                }
            }
        }

    }
}