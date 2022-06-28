using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            Dictionary<double, int> dictionary = new Dictionary<double, int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i], 1);
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }

            foreach (var dic in dictionary)
            {
                Console.WriteLine($"{dic.Key} - {dic.Value} times");
            }

        }
    }
}