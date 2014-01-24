// You are given a text. Write a program that changes the text in all regions surrounded by the tags
// <upcase> and </upcase> to uppercase. The tags cannot be nested.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder changedText = new StringBuilder();

            string openTagUpCase = "<upcase>";
            string closeTagUpCase = "</upcase>";
            
            int openIndex = text.IndexOf(openTagUpCase);
            int closeIndex = text.IndexOf(closeTagUpCase);

            int stringStartIndex = openIndex + openTagUpCase.Length;
            int stringEndIndex = closeIndex - 1;

            string s = text.Substring(openIndex, closeIndex);

            Console.WriteLine(s);
            Console.WriteLine(stringStartIndex);
            Console.WriteLine(stringEndIndex);
            Console.WriteLine(text);
        }
    }
}
