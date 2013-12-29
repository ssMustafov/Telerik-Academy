using System;
//using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        long firstNumber = 0;
        long secondNumber = 1;

        Console.Write(0 + " ");
        for (int i = 0; i < 100; i++)
        {
            long nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
            Console.Write(nextNumber + " ");
        }
    }
}