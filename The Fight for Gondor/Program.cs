using System;
using System.Collections.Generic;
using System.Linq;

namespace _1TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            int[] plates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int plateToAdd = 0;

            var defensePlates = new List<int>(plates);

            var attackOrcs = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                if (i % 3 == 0)
                {
                    int[] orcs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < orcs.Length; j++)
                    {
                        attackOrcs.Push(orcs[j]);
                    }
                    plateToAdd = int.Parse(Console.ReadLine());
                    defensePlates.Add(plateToAdd);
                }
                else
                {
                    int[] warriors = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < warriors.Length; j++)
                    {
                        attackOrcs.Push(warriors[j]);
                    }
                }

                var warriorsList = attackOrcs.ToList();

                attackOrcs.Clear();

                while (defensePlates.Count > 0 && warriorsList.Count > 0)
                {
                    if (defensePlates[0] > warriorsList[0])
                    {
                        defensePlates[0] = defensePlates[0] - warriorsList[0];
                        warriorsList.RemoveAt(0);
                    }
                    else if (defensePlates[0] < warriorsList[0])
                    {
                        warriorsList[0] = warriorsList[0] - defensePlates[0];
                        defensePlates.RemoveAt(0);
                    }
                    else if (defensePlates[0] == warriorsList[0])
                    {
                        defensePlates.RemoveAt(0);
                        warriorsList.RemoveAt(0);
                    }
                }

                if (defensePlates.Count == 0 && warriorsList.Count > 0)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    Console.WriteLine($"Orcs left: {string.Join(", ", warriorsList)}");
                    break;
                }
                else if (warriorsList.Count == 0 && defensePlates.Count > 0 && i == waves)
                {
                    Console.WriteLine("The people successfully repulsed the orc's attack.");
                    Console.WriteLine($"Plates left: {string.Join(", ", defensePlates)}");
                    break;
                }
            }
        }
    }
}