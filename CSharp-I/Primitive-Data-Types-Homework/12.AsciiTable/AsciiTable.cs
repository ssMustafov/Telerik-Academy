using System;

class AsciiTable
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 128; i++)
        {
            Console.WriteLine((char) i);
        }
    }
}