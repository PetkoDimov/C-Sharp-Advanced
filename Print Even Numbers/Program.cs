using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(input);
            Queue<int> result = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = numbers.Peek();

                if (currentNumber % 2 != 0)
                {
                    numbers.Dequeue();
                }
                else
                {
                    result.Enqueue(numbers.Dequeue());
                }

            }

            Console.WriteLine(string.Join(", " , result));
            
        }
    }
}
