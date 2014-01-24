// Write a program that replaces all occurrences of the substring "start"
// with the substring "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;

namespace Substring
{
    class Program
    {
        static string ReplaceSubStrings(string text)
        {
            StringBuilder replaceText = new StringBuilder();
            replaceText.Append(text);
            replaceText.Replace("start", "finish");

            return replaceText.ToString();
        }
        
        static void Main(string[] args)
        {
            try
            {
                string replacedText;

                StreamReader originalFile = new StreamReader("file.txt", Encoding.GetEncoding("windows-1251"));
                using (originalFile)
                {
                    string content = originalFile.ReadToEnd();
                    replacedText = ReplaceSubStrings(content);
                }

                StreamWriter replacedFile = new StreamWriter("file.txt", false, Encoding.GetEncoding("windows-1251"));
                using (replacedFile)
                {
                    replacedFile.Write(replacedText);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
     }
}
