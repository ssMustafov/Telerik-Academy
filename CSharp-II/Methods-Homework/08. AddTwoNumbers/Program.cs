// Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace AddTwoNumbers
{
    class Program
    {
        static int CountDigits(BigInteger number)
        {
            BigInteger num = number;
            int counter = 0;

            while (num != 0)
            {
                int c = (int)(num % 10);
                counter++;
                num /= 10;
            }

            return counter;
        }

        static void ArrayToNumber(int[] array)
        {
            BigInteger number = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                number = number * 10 + array[i];
            }

            Console.WriteLine("The number is: {0}", number);
        }

        static void AddTwoIntegers(BigInteger number1, BigInteger number2)
        {
            int[] digitsNum1 = new int[CountDigits(number1)];
            int[] digitsNum2 = new int[CountDigits(number2)];

            for (int index = 0; index < digitsNum1.Length; index++)
            {
                int c = (int)(number1 % 10);

                digitsNum1[index] = c;

                number1 /= 10;
            }

            for (int index = 0; index < digitsNum2.Length; index++)
            {
                int c = (int)(number2 % 10);

                digitsNum2[index] = c;

                number2 /= 10;
            }

            int longestNumber = 0;
            if (digitsNum1.Length > digitsNum2.Length)
            {
                longestNumber = digitsNum1.Length;
            }
            else
            {
                longestNumber = digitsNum2.Length;
            }

            int[] sumArray = new int[longestNumber];
            int addition = 0;

            for (int index = 0; index < sumArray.Length; index++)
            {
                int currentNumOne;
                int currentNumTwo;

                // Check the boundaries of the arrays
                if (index >= digitsNum1.Length)
                {
                    currentNumOne = 0;
                }
                else
                {
                    currentNumOne = digitsNum1[index];
                }

                if (index >= digitsNum2.Length)
                {
                    currentNumTwo = 0;
                }
                else
                {
                    currentNumTwo = digitsNum2[index];
                }

                // Calc the sum
                int current = 0;
                int currentSum = currentNumOne + currentNumTwo + addition;

                if (currentSum >= 10)
                {
                    current = currentSum - 10;
                    sumArray[index] = current;
                    addition = 1;
                }
                else
                {
                    current = currentSum;
                    sumArray[index] = current;
                    addition = 0;
                }

                // Adjusting the number sum from addition
                if ((index == longestNumber - 1) && (currentSum >= 10))
                {
                    sumArray[index] += 10;
                }
            }

            ArrayToNumber(sumArray);
        }

        static void Main(string[] args)
        {
            BigInteger n1 = BigInteger.Parse(Console.ReadLine());
            BigInteger n2 = BigInteger.Parse(Console.ReadLine());

            AddTwoIntegers(n1, n2);
        }
    }
}
