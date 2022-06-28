using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {

            int bulletPrice = int.Parse(Console.ReadLine());
            int gunbarrelSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);

            int[] locksInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);

            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currentGunBarrelSize = gunbarrelSize;

            while (bullets.Any() && locks.Any())
            {


                int currentBullet = bullets.Pop();
                bulletsCount++;
                currentGunBarrelSize--;
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentGunBarrelSize == 0 && bullets.Any())
                {

                    currentGunBarrelSize = gunbarrelSize;
                    Console.WriteLine("Reloading!");
                }

            }

            if (!locks.Any())
            {
                int moneyEarned = intelligenceValue - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
