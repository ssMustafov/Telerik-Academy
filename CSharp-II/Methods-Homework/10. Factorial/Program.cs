// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void CalcFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                Console.WriteLine("{0}! --> {1}", i, factorial);
                factorial = 1;
            }
        }

        static void Main(string[] args)
        {
            CalcFactorial(500);
        }
    }
}
