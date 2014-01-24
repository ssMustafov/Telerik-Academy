// Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceWords
{
    class Program
    {
        static string ReplaceSubStrings(string text)
        {
            StringBuilder replaceText = new StringBuilder();
            replaceText.Append(text);

            replaceText.Replace(" start ", " finish ");
            replaceText.Replace(" start", " finish");
            replaceText.Replace("start ", "finish ");

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
