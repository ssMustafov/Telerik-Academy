using System;

class DeclareChar
{
    static void Main(string[] args)
    {
        char a = '\u0048'; // with unicode code
        Console.WriteLine(a);

        Console.WriteLine((char) 72); // with char concatenation
    }
}