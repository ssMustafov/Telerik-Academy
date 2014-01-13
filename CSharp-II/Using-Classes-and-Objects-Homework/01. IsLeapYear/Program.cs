// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsLeapYear
{
    class Program
    {
        static bool IsALeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Is a leap year: {0}", IsALeapYear(year));
        }
    }
}
