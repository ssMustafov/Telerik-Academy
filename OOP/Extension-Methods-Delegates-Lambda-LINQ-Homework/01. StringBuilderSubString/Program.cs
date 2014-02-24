// Implement an extension method Substring(int index, int length) for the class StringBuilder that 
// returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Text;

namespace _01.StringBuilderSubString
{
    public static class SubStringExtensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            StringBuilder newString = new StringBuilder();
            newString.Append(sb.ToString().Substring(index, length));
            
            return newString;
        }
    }
    
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Test the extension method!");
            StringBuilder newSb = new StringBuilder();
            newSb = sb.SubString(19, 6);

            Console.WriteLine(newSb);
        }
    }
}
