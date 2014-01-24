// We are given a string containing a list of forbidden words and a text containing some of these words. 
// Write a program that replaces the forbidden words with asterisks. 
// Words: "PHP, CLR, Microsoft"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.ForbiddenWords
{
    class Program
    {
        static void Main()
        {
            List<string> forbiddenWords = new List<string>{"PHP", "CLR", "Microsoft"};
            
            string input = Console.ReadLine();

            Console.WriteLine(RemoveForbiddenWords(forbiddenWords, input));
        }

        private static string RemoveForbiddenWords(List<string> forbiddenWords, string input)
        {
            StringBuilder removeForbiddenWords = new StringBuilder(input);

            for (int i = 0; i < forbiddenWords.Count; i++)
            {
                removeForbiddenWords.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }

            return removeForbiddenWords.ToString();
        }
    }
}
