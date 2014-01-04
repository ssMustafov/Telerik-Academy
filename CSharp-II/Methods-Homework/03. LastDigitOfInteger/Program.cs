// Write a method that returns the last digit of given integer as an English word.
// Examples: 512 --> "two", 1024 --> "four", 12309 --> "nine".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastDigitOfInteger
{
    class Program
    {
        static string LastDigitNameOfNumber(int number)
        {
            int lastDigit = number % 10;
            string digitName = "";

            switch (lastDigit)
            {
                case 0: digitName = "Zero"; break;
                case 1: digitName = "One"; break;
                case 2: digitName = "Two"; break;
                case 3: digitName = "Three"; break;
                case 4: digitName = "Four"; break;
                case 5: digitName = "Five"; break;
                case 6: digitName = "Six"; break;
                case 7: digitName = "Seven"; break;
                case 8: digitName = "Eight"; break;
                case 9: digitName = "Nine"; break;
                default: break;
            }

            return digitName;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            string lastDigit = LastDigitNameOfNumber(number);
            Console.WriteLine("The last digit of {0} is: {1}", number, lastDigit);
        }
    }
}
