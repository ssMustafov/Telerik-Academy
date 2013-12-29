using System;

class SumIntegers
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        int sum = number1 + number2 + number3;
        Console.WriteLine("The sum is: {0}", sum);
    }
}