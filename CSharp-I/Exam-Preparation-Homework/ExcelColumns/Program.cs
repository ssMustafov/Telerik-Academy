using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long index = 0;

        for (int i = 1; i <= n; i++)
        {
            char letter = char.Parse(Console.ReadLine());

            index = index * 26;
            index = index + letter - 'A' + 1;
        }

        Console.WriteLine(index);
    }
}