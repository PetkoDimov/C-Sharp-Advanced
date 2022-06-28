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

            Queue<string> potatoQueue = new Queue<string>();

            while (true)
            {
                potatoQueue.Enqueue(potatoQueue.Dequeue());
            }
        }
    }
}
