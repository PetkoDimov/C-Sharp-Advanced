using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];
            int sum = 0;
            int maxSum = int.MinValue;
            int rowIndex = -1;
            int colIndex = -1;

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }

            for (int row = 0; row < matrixSizes[0] - 2; row++)
            {

                for (int col = 0; col < matrixSizes[1] - 2; col++)
                {

                    sum += matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];
                    
                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                    sum = 0;
                }

            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = rowIndex; row < rowIndex + 3; row++)
            {

                for (int col = colIndex; col < colIndex + 3; col++)
                {

                    Console.Write($"{matrix[row, col]} ");

                }
                Console.WriteLine();
            }
        }
    }
}
