using System;
using System.Linq;

namespace _10E._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrixLair = new char[nums[0], nums[1]];
            ReadMatrix(matrixLair);
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < matrixLair.GetLength(0); row++)
            {
                for (int col = 0; col < matrixLair.GetLength(1); col++)
                {
                    if (matrixLair[row, col] != '.'
                        && matrixLair[row, col] != 'B'
                        && matrixLair[row, col] != 'P')
                    {
                        return;
                    }
                    if (matrixLair[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                        matrixLair[row, col] = '.';
                    }
                }
            }
            char[] command = Console.ReadLine().ToCharArray();

            for (int i = 0; i < command.Length; i++)
            {
                char currentCommand = command[i];

                if (currentCommand == 'U')
                {
                    playerRow--;
                    BunnyAttacks(matrixLair);
                    BigB(matrixLair);
                }
                else if (currentCommand == 'D')
                {
                    playerRow++;
                    BunnyAttacks(matrixLair);
                    BigB(matrixLair);
                }
                else if (currentCommand == 'L')
                {
                    playerCol--;
                    BunnyAttacks(matrixLair);
                    BigB(matrixLair);
                }
                else if (currentCommand == 'R')
                {
                    playerCol++;
                    BunnyAttacks(matrixLair);
                    BigB(matrixLair);
                }
                if (playerRow < 0 || playerRow >= matrixLair.GetLength(0) || playerCol >= matrixLair.GetLength(1) || playerCol < 0)
                {
                    PrintMatrix(matrixLair);
                    if (playerRow < 0)
                    {
                        playerRow = 0;
                    }
                    if (playerRow > matrixLair.GetLength(0) - 1)
                    {
                        playerRow = matrixLair.GetLength(0) - 1;
                    }
                    if (playerCol < 0)
                    {
                        playerCol = 0;
                    }
                    if (playerCol > matrixLair.GetLength(1) - 1)
                    {
                        playerCol = matrixLair.GetLength(1) - 1;
                    }
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    return;
                }
                if (matrixLair[playerRow, playerCol] == 'B')
                {
                    PrintMatrix(matrixLair);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    return;
                }
            }



        }

        private static void PrintMatrix(char[,] matrixLair)
        {
            for (int row = 0; row < matrixLair.GetLength(0); row++)
            {
                for (int col = 0; col < matrixLair.GetLength(1); col++)
                {
                    Console.Write(matrixLair[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void BigB(char[,] matrixLair)
        {
            for (int row = 0; row < matrixLair.GetLength(0); row++)
            {
                for (int col = 0; col < matrixLair.GetLength(1); col++)
                {
                    if (matrixLair[row, col] == 'b')
                    {
                        matrixLair[row, col] = 'B';
                    }
                }
            }
        }

        private static void BunnyAttacks(char[,] matrixLair)
        {
            for (int row = 0; row < matrixLair.GetLength(0); row++)
            {
                for (int col = 0; col < matrixLair.GetLength(1); col++)
                {
                    if (matrixLair[row, col] == 'B')
                    {
                        if (row - 1 >= 0 && matrixLair[row - 1, col] == '.')
                        {
                            matrixLair[row - 1, col] = 'b';
                        }
                        if (col - 1 >= 0 && matrixLair[row, col - 1] == '.')
                        {
                            matrixLair[row, col - 1] = 'b';
                        }
                        if (row + 1 < matrixLair.GetLength(0) && matrixLair[row + 1, col] == '.')
                        {
                            matrixLair[row + 1, col] = 'b';
                        }
                        if (col + 1 < matrixLair.GetLength(1) && matrixLair[row, col + 1] == '.')
                        {
                            matrixLair[row, col + 1] = 'b';
                        }

                    }
                }
            }
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = data[col];
                }
            }
        }
    }
}