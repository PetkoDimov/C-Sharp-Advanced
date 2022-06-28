using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songs = new Queue<string>(input);

            input = Console.ReadLine().Split(" ").ToArray();

            while (songs.Any())
            {
                string command = input[0];

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {

                    string nameOfSong = string.Empty;
                    string[] temp = new string[input.Length - 1];

                    for (int i = 1; i < input.Length; i++)
                    {
                        temp[i - 1] = input[i];
                    }
                    nameOfSong = string.Join(" ", temp);

                    if (songs.Contains(nameOfSong))
                    {
                        Console.WriteLine($"{nameOfSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(nameOfSong);
                    }

                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                if (!songs.Any())
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                input = Console.ReadLine().Split(" ").ToArray();

            }

        }
    }
}
