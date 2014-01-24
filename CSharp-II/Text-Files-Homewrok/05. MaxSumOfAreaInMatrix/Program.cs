// Write a program that reads a text file containing a square matrix of numbers and
// finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MaxSumOfAreaInMatrix
{
    class Program
    {
        static int MaxPlatform(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("Matrix dimensions are not equal");
            }

            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            return bestSum;
        }

        static int[,] ReadTheMatrixFromFile(string fileName)
        {
            int size;
            int lineCounter = 0;
            int[,] matrix;

            StreamReader inputFile = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
            using (inputFile)
            {
                // Read the matrix size from the first line
                string sizeString = inputFile.ReadLine();
                size = int.Parse(sizeString);

                // Set the matrixs dimensions
                matrix = new int[size, size];

                // Read the numbers and reinitalize the matrix
                string numbers = inputFile.ReadLine();
                while (numbers != null)
                {
                    string[] array = numbers.Split(' ');
                    for (int i = 0; i < array.Length; i++)
                    {
                        matrix[lineCounter, i] = int.Parse(array[i]);
                    }

                    numbers = inputFile.ReadLine();
                    lineCounter++;
                }
            }

            return matrix;
        }

        static void PrintSumInFile(string fileName, int sum)
        {
            StreamWriter outputFile = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
            using (outputFile)
            {
                outputFile.WriteLine(sum);
            }
        }

        static void Main()
        {
            try
            {
                var matrix = ReadTheMatrixFromFile("input.txt");

                int sum = MaxPlatform(matrix);

                PrintSumInFile("output.txt", sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("The input is incorrect");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The matrix dimensions are not equal");
            }
        }
   }
}
