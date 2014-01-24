// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SortStrings
{
    static List<string> TakeNamesFromFile(string fileName)
    {
        List<string> names = new List<string>();

        StreamReader input = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
        using (input)
        {
            string line = input.ReadLine();

            while (line != null)
            {
                if (line != "")
                {
                    names.Add(line);
                }
                
                line = input.ReadLine();
            }
        }

        return names;
    }

    static void WriteToFile(List<string> namesSorted, string fileName)
    {
        StreamWriter output = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
        using (output)
        {
            for (int i = 0; i < namesSorted.Count; i++)
            {
                output.WriteLine(namesSorted[i]);
            }
        }
    }

    static void Main()
    {
        try
        {
            var names = TakeNamesFromFile("inputa.txt");

            names.Sort();

            WriteToFile(names, "output.txt");
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }
}