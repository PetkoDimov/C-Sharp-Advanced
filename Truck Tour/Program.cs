﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Gas_Stations
{
    class Program
    {
        static void Main(string[] args)
        {

            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<string> pumpsData = new Queue<string>();
            bool isSuccessfull = true;

            for (int i = 0; i < pumpsCount; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }

            for (int i = 0; i < pumpsCount; i++)
            {
                int currentPetrolAmount = 0;
                isSuccessfull = true;

                for (int j = 0; j < pumpsCount; j++)
                {
                    string pumpDataStr = pumpsData.Dequeue();
                    int[] pumpData = pumpDataStr.Split(" ").Select(int.Parse).ToArray();
                    pumpsData.Enqueue(pumpDataStr);

                    currentPetrolAmount += pumpData[0];

                    currentPetrolAmount -= pumpData[1];
                    if (currentPetrolAmount < 0)
                    {
                        isSuccessfull = false;
                    }
                }

                if (isSuccessfull)
                {
                    Console.WriteLine(i);
                    break;
                }

                string tempData = pumpsData.Dequeue();
                pumpsData.Enqueue(tempData);

            }

        }
    }
}
