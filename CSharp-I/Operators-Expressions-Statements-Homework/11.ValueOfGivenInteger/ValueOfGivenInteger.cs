using System;

class ValueOfGivenInteger
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int i = int.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1;
        mask = mask << b;

        int andMask = i & mask;
        int bit = andMask >> b;

        Console.WriteLine(bit);
    }
}