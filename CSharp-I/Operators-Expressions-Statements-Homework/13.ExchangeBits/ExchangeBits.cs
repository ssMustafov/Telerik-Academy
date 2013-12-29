using System;

class ExchangeBits
{
    static void Main(string[] args)
    {
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1;
        byte thirdBit = 3;
        byte fourthBit = 4;
        byte fifthBit = 5;
        byte twentyFourBit = 24;
        byte twentyFiveBit = 25;
        byte twentySixBit = 26;

        // take the 3 bit
        mask = mask << thirdBit;
        uint and = mask & number;
        uint takeThirdBit = and >> thirdBit;
        Console.WriteLine(takeThirdBit);

        // take the 4 bit
        uint mask1 = 1;
        mask1 = mask1 << fourthBit;
        uint fourAnd = mask1 & number;
        uint takeFourthBit = fourAnd >> fourthBit;
        Console.WriteLine(takeFourthBit);

        // take the 5 bit
        uint mask2 = 1;
        mask2 = mask2 << fifthBit;
        uint fiveAnd = mask2 & number;
        uint takeFifthBit = fiveAnd >> fifthBit;
        Console.WriteLine(takeFifthBit);

        // take the 24 bit
        uint mask3 = 1;
        mask3 = mask3 << twentyFourBit;
        uint twentyFourAnd = mask3 & number;
        uint takeTwentyFourBit = twentyFourAnd >> twentyFourBit;
        Console.WriteLine(takeTwentyFourBit);

        // take the 25 bit
        uint mask4 = 1;
        mask4 = mask4 << twentyFiveBit;
        uint twentyFiveAnd = mask4 & number;
        uint takeTwentyFiveBit = twentyFiveAnd >> twentyFiveBit;
        Console.WriteLine(takeTwentyFiveBit);

        // take the 26 bit
        uint mask5 = 1;
        mask5 = mask5 << twentySixBit;
        uint twentySixAnd = mask5 & number;
        uint takeTwentySixBit = twentySixAnd >> twentySixBit;
        Console.WriteLine(takeTwentySixBit);

        // start exchange
        /*mask = mask << 3;
        uint bitOne = (mask & number) >> 3;
        mask = mask >> 3;
        mask = mask << 24;
        uint bitTwo = (mask & number) >> 24;
        mask >>= 24;*/

        // TODO

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}