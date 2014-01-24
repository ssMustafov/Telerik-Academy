// Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Text;

namespace DeleteOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textWithEvenLines = "";

            StreamReader reader = new StreamReader("text.txt", Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                int lineCounter = 0;

                string line = reader.ReadLine();
                while (line != null)
                {
                    lineCounter++;

                    if (lineCounter % 2 == 0)
                    {
                        textWithEvenLines += line;
                    }
                    textWithEvenLines += Environment.NewLine;
                    line = reader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter("text.txt", false, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                writer.Write(textWithEvenLines);
            }
        }
    }
}
