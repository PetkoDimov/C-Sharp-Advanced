using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> theWorld = new Dictionary<string, Dictionary<string, List<string>>>();
            //continent          country            cities
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!theWorld.ContainsKey(continent))
                {
                    theWorld.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!theWorld[continent].ContainsKey(country))
                {
                    theWorld[continent].Add(country, new List<string>());
                }
                theWorld[continent][country].Add(city);
            }

            foreach (var countinent in theWorld)
            {
                Console.WriteLine($"{countinent.Key}:");

                foreach (var country in countinent.Value)
                {

                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");

                }
            }

        }

    }
}