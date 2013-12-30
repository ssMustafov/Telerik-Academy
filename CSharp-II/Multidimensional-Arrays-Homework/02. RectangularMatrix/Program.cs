// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class Program
{
    static void Main()
    {
        // Read the matrix size
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());

        // Declare the matrix
        int[,] matrix = new int[n, m];

        // Initialize the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("[{0}][{1}]: ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        // Print the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        // Find the max sum of 3x3
        int sum = 0;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 1; col < matrix.GetLength(1)-1; col++)
            {
                sum = matrix[row, col] + matrix[row, col - 1] + matrix[row, col + 1] + matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the matrix of the best sum
        Console.WriteLine("The max sum of 3x3 is: {0}", bestSum);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol - 1], matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol - 1], matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
    }
}