//* Write a program that finds the largest area of equal neighbor elements in
//a rectangular matrix and prints its size.

using System;

class Program
{
    static int currentSum = 0;
    static int[,] directions = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

    public static bool IsTraversable(int[,] matrix, int x, int y)
    {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
    }

    public static void DFS(int[,] matrix, int row, int col)
    {
        int value = matrix[row, col];

        matrix[row, col] = 0;

        currentSum++;

        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            int rowS = row + directions[direction, 0];
            int colS = col + directions[direction, 1];

            if (IsTraversable(matrix, rowS, colS) && matrix[rowS, colS] == value)
            {
                DFS(matrix, rowS, colS);
            }
        }
    }

    static void Main()
    {
        int[,] matrix = 
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1}
        };

        Console.WriteLine("Print matrix:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        int maxSum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] != 0)
                {
                    currentSum = 0;
                    DFS(matrix, row, col);

                    maxSum = Math.Max(maxSum, currentSum);
                }
            }
        }

        Console.Write("The largest area of equal neighbor elements: ");
        Console.WriteLine(maxSum);
    }
}