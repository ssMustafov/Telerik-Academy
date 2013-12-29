using System;

class GreaterNumber
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int greaterNumber = (number1 > number2) ? number1 : number2;
        Console.WriteLine(greaterNumber);
    }
}