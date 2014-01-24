// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary = 
            {
                ".NET - platform for applications from Microsoft",
                "CLR - managed execution environment for .NET",
                "namespace - hierarchical organization of classes",
                "string - sequences of characters",
                "C# - programming language for .NET",
                "HTML - main markup language for creating web pages and other information that can be displayed in a web browser"
            };

            string word = Console.ReadLine();

            Console.WriteLine(SearchInDictionary(dictionary, word));
        }

        private static string SearchInDictionary(string[] dictionary, string word)
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i].ToLower().StartsWith(word.ToLower()))
                {
                    return dictionary[i];
                }
            }

            return "Word not found";
        }
    }
}
