using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> numbers = new Stack<int>();
            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int cmdArg = commands[0];

                if (cmdArg == 1)
                {
                    int number = commands[1];
                    numbers.Push(number);
                }
                else if (cmdArg == 2 && numbers.Any())
                {
                    numbers.Pop();
                }
                else if (cmdArg == 3 && numbers.Any())
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (cmdArg == 4 && numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }


            }
            if (numbers.Any())
            {
                Console.WriteLine(string.Join(", ", numbers));
            }
        }
    }
}
