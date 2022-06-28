using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string command = Console.ReadLine();
            char identifier = ' ';
            int sum = 0;
            while (command != "END")
            {
                if (command == "PARTY")
                {
                    while (command != "END")
                    {


                        command = Console.ReadLine();
                        if (vip.Contains(command))
                        {
                            vip.Remove(command);
                        }
                        else if (regular.Contains(command))
                        {
                            regular.Remove(command);
                        }
                    }
                    break;
                }

                identifier = command[0];
                if (char.IsDigit(identifier) && command.Length == 8)
                {
                    vip.Add(command);
                }
                else if (char.IsLetter(identifier) && command.Length == 8)
                {
                    regular.Add(command);
                }


                command = Console.ReadLine();
            }
            sum = regular.Count + vip.Count;
            Console.WriteLine(sum);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }

    }
}