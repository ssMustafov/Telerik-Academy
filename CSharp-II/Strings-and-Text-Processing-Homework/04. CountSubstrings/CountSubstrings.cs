// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CountSubstrings
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter string to search:");
        string searchFor = Console.ReadLine();

        int count = CountSubstring(input, searchFor);

        Console.WriteLine("The string {0} containts {1} times", searchFor, count);
    }

    private static int CountSubstring(string input, string searchFor)
    {
        int count = 0;
        if (searchFor != "")
        {
            for (int i = 0; i < input.Length; i++)
            {
                int index = input.ToLower().IndexOf(searchFor.ToLower(), i);

                if (index > 0)
                {
                    count++;
                    i = index;
                }
            }
        }

        return count;
    }
}