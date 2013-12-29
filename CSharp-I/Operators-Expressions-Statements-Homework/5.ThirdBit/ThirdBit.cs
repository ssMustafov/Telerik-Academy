using System;

class ThirdBit
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int position = 3;

        // initilization of mask
        int mask = 1;
        mask = mask << position;

        int positionAndMask = number & mask;
        int bit = positionAndMask >> position;
		Console.WriteLine(bit);
    }
}