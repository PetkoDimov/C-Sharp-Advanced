using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            // nikakvi poruchki ili hrana za denq
            int quantityForTheDay = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(input);
            int counter = orders.Count;

            Console.WriteLine(orders.Max());

            for (int i = 0; i < counter; i++)
            {

                if (quantityForTheDay >= orders.Peek())
                {

                    quantityForTheDay -= orders.Dequeue();


                    if (!orders.Any())
                    {
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }

            }
        }
    }
}
