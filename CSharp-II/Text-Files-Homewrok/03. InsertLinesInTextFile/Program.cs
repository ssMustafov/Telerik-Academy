// Write a program that reads a text file and inserts line numbers in front of each of its lines. 
// The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InsertLinesInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Program.cs", Encoding.GetEncoding("windows-1251"));
            int lineCount = 1;

            using (reader)
            {
                StreamWriter writer = new StreamWriter("sample.txt", false, Encoding.GetEncoding("windows-1251"));
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine("Line {0}: {1}", lineCount, line);

                        line = reader.ReadLine();
                        lineCount++;
                    }
                }
            }
        }
    }
}