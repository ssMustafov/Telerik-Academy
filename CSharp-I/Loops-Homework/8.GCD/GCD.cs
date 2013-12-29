/*
 Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm. 
*/

using System;

class GCD
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        while (secondNumber != 0)
        {
            int c = secondNumber;
            secondNumber = firstNumber % secondNumber;
            firstNumber = c;
        }
        Console.WriteLine(firstNumber);
    }
}