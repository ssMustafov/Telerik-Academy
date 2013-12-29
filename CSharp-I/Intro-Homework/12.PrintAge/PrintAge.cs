using System;

class PrintAge
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years will be: {0}", age + 10);
    }
}