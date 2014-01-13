// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except
// a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workdays
{
    class Program
    {
        static bool IsHolidayDay(int day, int month)
        {
            int[,] holidays =
            { 
                //day, month    
                {1, 1}, 
                {3, 3},
                {18, 4},
                {19, 4},
                {20, 4},
                {1, 5},
                {6, 5},
                {24, 5},
                {6, 9},
                {22, 9},
                {1, 11},
                {24, 12},
                {25, 12},
                {26, 12},
                {31, 12}
            };
            
            bool isHoliday = false;

            for (int row = 0; row < holidays.GetLength(0); row++)
            {
                if (holidays[row, 1] == month)
                {
                    for (int col = 0; col < holidays.GetLength(1); col++)
                    {
                        if (holidays[row, col] == day)
                        {
                            isHoliday = true;
                        }
                    }
                }
            }
            
            return isHoliday;
        }
        
        static int NumberOfWorkdays(int day, int month, int year)
        {
            DateTime today = DateTime.Now;
            DateTime next = new DateTime(year, month, day);

            TimeSpan days = next.Subtract(today);
            int totalDays = (int)(Math.Ceiling((days.TotalDays)));
            
            int counter = 0;
            
            for (int i = 1; i <= totalDays; i++)
            {
                if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (!IsHolidayDay(today.Day, today.Month))
                    {
                        counter++;
                    }
                }

                today = today.AddDays(1);
            }
            
            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a day:");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter a month:");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of wordays are: {0}", NumberOfWorkdays(day, month, year));
        }
    }
}
