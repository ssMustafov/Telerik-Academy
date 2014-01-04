// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountNumber
{
    class Program
    {
        static int CountNumberIsInArray(int[] array, int number)
        {
            int count = 0;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == number)
                {
                    count++;
                }
            }

            return count;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to count in array:");
            int number = int.Parse(Console.ReadLine());

            int[] array = { 4, -7, 20, 5, 0, -1, 3, 4, 4, 5, 0, 5, 5 };

            int count = CountNumberIsInArray(array, number);
            Console.WriteLine(count);
        }
    }
}
