using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            int[] numbersInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = data[0];
            int s = data[1];
            int x = data[2];

            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(numbersInput[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            isFound = numbers.Contains(x);

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }

        }
    }
}
