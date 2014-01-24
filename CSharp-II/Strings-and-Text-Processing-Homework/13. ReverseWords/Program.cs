// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder reversedWordsInText = new StringBuilder();

            char[] separators = { ' ', '!', ':', '?', ',' };

            string[] separatedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = separatedText.Length - 1; i >= 0; i--)
            {
                reversedWordsInText.Append(separatedText[i] + " ");
            }

            Console.WriteLine(reversedWordsInText.ToString());
        }
    }
}