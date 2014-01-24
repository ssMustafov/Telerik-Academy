// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.NumberOfDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first date in format day.month.year");
            string firstDate = Console.ReadLine();

            Console.WriteLine("Please enter second date in format day.month.year");
            string secondDate = Console.ReadLine();

            char[] separator = { '.' };

            string[] firstDates = firstDate.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string[] secondDates = secondDate.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            DateTime first = new DateTime(int.Parse(firstDates[2]), int.Parse(firstDates[1]), int.Parse(firstDates[0]));
            DateTime second = new DateTime(int.Parse(secondDates[2]), int.Parse(secondDates[1]), int.Parse(secondDates[0]));

            Console.WriteLine("Distance: {0}", second.Day - first.Day);
        }
    }
}