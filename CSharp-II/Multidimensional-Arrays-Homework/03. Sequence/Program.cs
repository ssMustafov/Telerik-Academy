// We are given a matrix of strings of size N x M. 
// Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("[{0}][{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        // Print the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        // Find the longest sequence
        int longestSeq = 1;
        int currentSeq = 1;
        string seq = "";

        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col < m; col++)
            {
                if (matrix[row, col] == matrix[row, col - 1])
                {
                    currentSeq++;
                    if (currentSeq > longestSeq)
                    {
                        longestSeq = currentSeq;
                        seq = matrix[row, col];
                    }
                }
                else
                {
                    currentSeq = 1;
                }
            }
            currentSeq = 1;
        }

        for (int col = 0; col < m; col++)
        {
            for (int row = 1; row < n; row++)
            {
                if (matrix[row, col] == matrix[row - 1, col])
                {
                    currentSeq++;
                    if (currentSeq > longestSeq)
                    {
                        longestSeq = currentSeq;
                        seq = matrix[row, col];
                    }
                }
                else
                {
                    currentSeq = 1;
                }
            }
            currentSeq = 1;
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (row + i > matrix.GetLength(0) - 1 || col + i > matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    if (matrix[row, col] == matrix[row + i, col + i])
                    {
                        currentSeq++;

                        if (currentSeq > longestSeq)
                        {
                            longestSeq = currentSeq;
                            seq = matrix[row, col];
                        }
                    }
                }
                currentSeq = 1;
                
                for (int i = 1; i < matrix.GetLength(1); i++)
                {
                    if (row - i < 0 || col + i > matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    if (matrix[row, col] == matrix[row - i, col + i])
                    {
                        currentSeq++;

                        if (currentSeq > longestSeq)
                        {
                            longestSeq = currentSeq;
                            seq = matrix[row, col];
                        }
                    }
                }
            }
        }

        Console.WriteLine("{0} => {1}", longestSeq, seq);
    }
}