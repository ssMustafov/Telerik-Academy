using System;

class ExchangeValues
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        if (numberOne > numberTwo)
        {
            numberOne = numberOne + numberTwo;
            numberTwo = numberOne - numberTwo;
            numberOne = numberOne - numberTwo;
        }
        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo);
    }
}