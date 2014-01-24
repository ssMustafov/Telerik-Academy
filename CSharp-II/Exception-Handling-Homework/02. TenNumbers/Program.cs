﻿// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers:
// a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class Program
{
    static void ReadNumber(int start, int end)
    {
        Console.Write("Enter a number from {0} to {1}: ", start, end);
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException(string.Format("The number is not in the current range {0} to {1}", start, end));
        }
    }

    static void Main()
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(1, 100);
            }
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException ar)
        {
            Console.WriteLine(ar.Message);
        }
    }
}