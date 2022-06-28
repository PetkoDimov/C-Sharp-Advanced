using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> value = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int number = int.Parse(Console.ReadLine());

            while (value.Peek() != number)
            {
                if (threads.Peek() >= value.Peek())
                {
                    value.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {threads.Peek()} killed task {number}\n{String.Join(" ", threads)}");
        }
    }
}