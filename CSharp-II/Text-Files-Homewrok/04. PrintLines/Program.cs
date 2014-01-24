// Write a program that compares two text files line by line and prints the number of lines
// that are the same and the number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace PrintLines
{
    class Program
    {
        static void Main()
        {
            int lineCounter = 1;
            List<int> same = new List<int>();
            List<int> different = new List<int>();

            StreamReader fileOne = new StreamReader("text1.txt", Encoding.GetEncoding("windows-1251"));
            using (fileOne)
            {
                StreamReader fileTwo = new StreamReader("text2.txt", Encoding.GetEncoding("windows-1251"));
                using (fileTwo)
                {
                    string lineOfFileOne = fileOne.ReadLine();
                    string lineOfFileTwo = fileTwo.ReadLine();

                    while (lineOfFileOne != null && lineOfFileTwo != null)
                    {
                        if (lineOfFileOne == lineOfFileTwo)
                        {
                            same.Add(lineCounter);
                        }
                        else
                        {
                            different.Add(lineCounter);
                        }

                        lineOfFileOne = fileOne.ReadLine();
                        lineOfFileTwo = fileTwo.ReadLine();
                        lineCounter++;
                    }
                }
            }

            Console.Write("Same lines: ");
            foreach (var elem in same)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();

            Console.Write("Not same lines: ");
            foreach (var elem in different)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}
