using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            int asterix = 2 * i + 1;
            int dots = n - i - 2;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', asterix));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }
        Console.Write(new string('.', n - 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n - 2));
        Console.WriteLine();
    }
}