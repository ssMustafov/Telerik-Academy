// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.PrintStringOf20Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Please enter string of maximum 20 chars:");
                input = Console.ReadLine();
            } while (input.Length >= 21);

            int length = 20 - input.Length;

            StringBuilder finalResult = new StringBuilder();

            finalResult.Append(input);
            finalResult.Append(new string('*', length));

            Console.WriteLine(finalResult);
        }
    }
}
