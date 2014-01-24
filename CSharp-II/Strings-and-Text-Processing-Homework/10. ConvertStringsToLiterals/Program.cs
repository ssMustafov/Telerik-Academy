// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.ConvertStringsToLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder unicodes = new StringBuilder();

            foreach (char letter in input)
            {
                string zeros = new string('0', ((int)letter).ToString("X").Length);
                unicodes.AppendFormat("\\u{0}{1:X}", zeros, (int)letter);
            }

            Console.WriteLine(unicodes.ToString());
        }
    }
}