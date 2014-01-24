// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder reversedInput = ReverseStringOrder(input);

        Console.WriteLine(reversedInput);
    }

    private static StringBuilder ReverseStringOrder(string input)
    {
        StringBuilder reversedInput = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedInput.Append(input[i]);
        }

        return reversedInput;
    }
}