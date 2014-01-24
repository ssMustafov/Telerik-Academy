// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PrintOddLines
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("text.txt", Encoding.GetEncoding("windows-1251"));
            
            using (reader)
            {
                int lineCounter = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (lineCounter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    lineCounter++;
                }
            }
        }
    }
}
