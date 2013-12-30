using System;

class Program
{
    static void Main()
    {
        // Read size of the matrix
        Console.Write("Enter the size of the matrix:");
        int n = int.Parse(Console.ReadLine());

        // Declare the matrix
        int[,] matrix = new int[n, n];

        // Initialize the matrix
        int counter = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[n - row + col - 1, col] = counter;
                counter++;
            }
        }

        for (int row = n-2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, n - col - 1] = counter;
                counter++;
            }
        }

        // Print the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}