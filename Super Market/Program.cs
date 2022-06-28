using System;
using System.Collections.Generic;

namespace Super_Market
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> clients = new Queue<string>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var item in clients)
                    {
                        Console.WriteLine(item);
                    }

                    clients.Clear();
                }
                else
                {
                    clients.Enqueue(input);
                }


                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine($"{clients.Count} people remaining.");
            }

        }
    }
}
