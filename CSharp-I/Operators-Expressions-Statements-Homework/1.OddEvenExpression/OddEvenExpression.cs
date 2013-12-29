using System;

class OddEvenExpression
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        dynamic oddOrEven = (a % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine(oddOrEven);
    }
}