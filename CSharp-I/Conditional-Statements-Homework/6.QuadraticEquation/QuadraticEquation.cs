using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        double descreminant = (b * b) - (4 * a * c);

        if (descreminant < 0)
        {
            Console.WriteLine("The equation has no real roots");
        }
        else if (descreminant == 0)
        {
            double onlyOneRoot = (-b) / (2 * a);
            Console.WriteLine("The equation's roots are: x1 = x2 = {0}", onlyOneRoot);
        }
        else
        {
            double rootOne = ((-b) + Math.Sqrt(descreminant)) / (2 * a);
            double rootTwo = ((-b) - Math.Sqrt(descreminant)) / (2 * a);
            Console.WriteLine("The equation's roots are: x1 = {0}   x2 = {1}", rootOne, rootTwo);
        }
    }
}