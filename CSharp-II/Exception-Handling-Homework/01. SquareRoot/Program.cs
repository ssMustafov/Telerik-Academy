// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print "Invalid number". 
// In all cases finally print "Good bye". Use try-catch-finally.

using System;

class Program
{
    static double SquareRoot(string numberAsString)
    {
        int number = Int32.Parse(numberAsString);

        if (number < 0)
        {
            throw new ArgumentException("Invalid number");
        }

        return Math.Sqrt(number);
    }

    static void Main()
    {
        try
        {
            string numberAsString = Console.ReadLine();
            Console.WriteLine(SquareRoot(numberAsString));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentException ax)
        {
            Console.WriteLine(ax.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}