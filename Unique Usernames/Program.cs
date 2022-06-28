using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            // test with Dictionary
            int n = int.Parse(Console.ReadLine());
            HashSet<string> hashSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                hashSet.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, hashSet));
        }
    }
}
