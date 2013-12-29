// Write a program that reads two arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("first: [{0}] = ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("second: [{0}] = ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("first[{0}]: {1} > second[{1}]: {2}", i, firstArray[i], i, secondArray[i]);
                }
                else if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("first[{0}]: {1} = second[{1}]: {2}", i, firstArray[i], i, secondArray[i]);
                }
                else
                {
                    Console.WriteLine("first[{0}]: {1} < second[{1}]: {2}", i, firstArray[i], i, secondArray[i]);
                }
            }
        }
    }
}
