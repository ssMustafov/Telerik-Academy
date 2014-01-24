// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            if (CountSymbol('(', expression) == CountSymbol(')', expression))
            {
                Console.WriteLine("The expression is correct");
            }
            else
            {
                Console.WriteLine("The expression is not correct");
            }
        }

        static int CountSymbol(char symbol, string input)
        {
            int index = input.IndexOf(symbol);
            int startIndex = 0;
            int count = 0;

            while (index != -1)
            {
                count++;
                startIndex = index + 1;
                index = input.IndexOf(symbol, startIndex);
            }

            return count;
        }
    }
}
