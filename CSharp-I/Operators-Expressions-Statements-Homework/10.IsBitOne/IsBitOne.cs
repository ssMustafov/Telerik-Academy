using System;

class IsBitOne
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int v = int.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1;
        mask = mask << p;

        int andMask = v & mask;
        int bit = andMask >> p;

        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}