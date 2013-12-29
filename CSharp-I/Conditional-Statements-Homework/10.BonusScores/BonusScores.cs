using System;

class BonusScores
{
    static void Main()
    {
        int inputDigit = int.Parse(Console.ReadLine());

        switch (inputDigit)
        {
            case 1:
            case 2:
            case 3:
                inputDigit *= 10;
                Console.WriteLine(inputDigit);
                break;
            case 4:
            case 5:
            case 6:
                inputDigit *= 100;
                Console.WriteLine(inputDigit);
                break;
            case 7:
            case 8:
            case 9:
                inputDigit *= 1000;
                Console.WriteLine(inputDigit);
                break;
            default: Console.WriteLine("ERROR"); break;
        }
    }
}