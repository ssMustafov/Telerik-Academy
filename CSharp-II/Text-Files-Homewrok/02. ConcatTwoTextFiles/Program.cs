// Write a program that concatenates two text files into another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConcatTwoTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader firstFile = new StreamReader("text1.txt", Encoding.GetEncoding("windows-1251"));
            
            using (firstFile)
            {
                StreamReader secondFile = new StreamReader("text2.txt", Encoding.GetEncoding("windows-1251"));
                using (secondFile)
                {
                    StreamWriter thirdFile = new StreamWriter("text3.txt", true, Encoding.GetEncoding("windows-1251"));
                    using (thirdFile)
                    {
                        string contentOfFileOne = firstFile.ReadToEnd();
                        string contentOfFileTwo = secondFile.ReadToEnd();

                        thirdFile.WriteLine(contentOfFileOne);
                        thirdFile.WriteLine(contentOfFileTwo);
                    }
                }
            }
        }
    }
}
