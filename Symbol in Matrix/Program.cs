using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            char[,] matrix = new char[input, input];
            int[] IndexOfMatch = new int[2];
            string result = string.Empty;
            bool isFound = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] matrixData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixData[col];

                }

            }
            string match = Console.ReadLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].ToString() == match)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                    if (isFound)
                    {
                        break;
                    }
                }

            }

            if (isFound == false)
            {

                Console.WriteLine($"{match} does not occur in the matrix");

            }
        }
    }
}