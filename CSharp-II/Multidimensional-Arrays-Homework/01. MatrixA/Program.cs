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
        
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = counter;
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