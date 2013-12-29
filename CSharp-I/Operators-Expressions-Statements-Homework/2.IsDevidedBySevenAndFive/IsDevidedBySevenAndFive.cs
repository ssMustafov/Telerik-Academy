using System;

class IsDevidedBySevenAndFive
{
    static void Main(string[] args)
    {
        int a = Int32.Parse(Console.ReadLine());
        bool isDivided = (a % 7 == 0 && a % 5 == 0) ? true : false;
        Console.WriteLine(isDivided);
    }
}