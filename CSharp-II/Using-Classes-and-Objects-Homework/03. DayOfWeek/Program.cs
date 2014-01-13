// Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayOfWeek
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Today is: ");
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
    }
}
