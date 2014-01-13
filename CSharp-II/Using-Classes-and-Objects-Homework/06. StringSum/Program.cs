// You are given a sequence of positive integer values written into a string, separated by spaces. 
// Write a function that reads these values from given string and calculates their sum. 
// Example: string = "43 68 9 23 318"  result = 461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringSum
{
    class Program
    {
        static int SumStringNumbers(string sequence)
        {
            string[] numberAsStrings = sequence.Split(' ');
            int[] numbers = new int[numberAsStrings.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numberAsStrings[i]);
            }

            int sum = 0;
            foreach (var nums in numbers)
            {
                sum += nums;
            }
            
            return sum;
        }

        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            
            Console.WriteLine(SumStringNumbers(sequence));
        }
    }
}
