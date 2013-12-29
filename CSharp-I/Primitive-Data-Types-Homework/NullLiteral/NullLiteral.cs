using System;

class NullLiteral
{
    static void Main(string[] args)
    {
        int? first = null;
        double? second = null;

        Console.WriteLine(first);
        Console.WriteLine(second);

        first = 10;
        Console.WriteLine(first);

        second = 1.33;
        Console.WriteLine(second);

        second = null;
        Console.WriteLine(second);

        first = null;
        Console.WriteLine(first);
    }
}