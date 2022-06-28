using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            int N = inputArr[0];
            int S = inputArr[1];
            int X = inputArr[2];

            for (int i = 0; i < N; i++)
            {
                stack.Push(array[i]);
            }
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
