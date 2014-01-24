// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and
// prints the date and time after 6 hours and 30 minutes (in the same format)
// along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace PrintDate
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date in format day.month.year hour:minute:second");
            string date = Console.ReadLine();

            DateTime newDate = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            newDate = newDate.AddHours(6.5);

            Console.WriteLine("{0} {1}", newDate, newDate.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
