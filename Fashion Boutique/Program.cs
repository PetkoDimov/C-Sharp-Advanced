using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] allClothesInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> allClothes = new Stack<int>(allClothesInput);

            int boxCapacity = int.Parse(Console.ReadLine());
            int currentRacksCapacity = boxCapacity;
            int racksCount = 1;

            while (allClothes.Any())
            {

                int clothes = allClothes.Pop();
                currentRacksCapacity -= clothes;

                if (currentRacksCapacity < 0)
                {
                    racksCount++;
                    currentRacksCapacity = boxCapacity - clothes;
                }
            }

            Console.WriteLine(racksCount);

        }
    }
}
