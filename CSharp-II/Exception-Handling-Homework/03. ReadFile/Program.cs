// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a full path with file name and extension");
        string fileName = Console.ReadLine();

        try
        {
            StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (FileLoadException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (FieldAccessException fa)
        {
            Console.WriteLine(fa.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot open file");
        }
    }
}