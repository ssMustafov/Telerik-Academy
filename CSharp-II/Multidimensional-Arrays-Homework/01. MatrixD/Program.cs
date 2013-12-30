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
        int left = 0;
        int right = n - 1;
        int top = 0;
        int bottom = n - 1;

        while (left < right && top < bottom)
        {
            // Down
            for (int i = top; i <= bottom; i++)
            {
                matrix[i, left] = counter;
                counter++;
            }
            left++;

            // Right
            for (int i = left; i <= right; i++)
            {
                matrix[bottom, i] = counter;
                counter++;
            }
            bottom--;

            // Up
            for (int i = bottom; i >= top; i--)
            {
                matrix[i, right] = counter;
                counter++;
            }
            right--;

            // Left
            for (int i = right; i >= left; i--)
            {
                matrix[top, i] = counter;
                counter++;
            }
            top++;
        }        

        // Print the matrix
        if (n == 1)
        {
            Console.WriteLine(1);
            return;
        }

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