using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());
        int bigger = 0;

        if (numberOne > numberTwo)
        {
            if (numberOne > numberThree)
            {
                bigger = numberOne;
            }
        }
        else
        {
            if (numberTwo > numberThree)
            {
                bigger = numberTwo;
            }
            else
            {
                bigger = numberThree;
            }
        }
        Console.WriteLine(bigger);
    }
}