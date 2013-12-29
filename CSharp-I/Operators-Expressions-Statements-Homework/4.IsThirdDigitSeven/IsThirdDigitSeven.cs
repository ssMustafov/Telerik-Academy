using System;

class IsThirdDigitSeven
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int thirdDigit = (a / 100) % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}