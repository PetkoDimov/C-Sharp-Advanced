using System;
using System.Linq;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            int potatoTosses = 0;

            Queue<string> potatoQueue = new Queue<string>(children);

            while (potatoQueue.Count > 1)
            {
                potatoTosses++;
                string kid = potatoQueue.Dequeue();
                if (potatoTosses == n)
                {
                    potatoTosses = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    potatoQueue.Enqueue(kid);
                }

            }

            Console.WriteLine("Last is " + potatoQueue.Dequeue());
        }
    }
}
