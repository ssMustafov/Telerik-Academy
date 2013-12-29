using System;

class WithinCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        if (((x*x) + (y*y)) <= (radius*radius))
        {
            Console.WriteLine("x = {0} and y = {1} are within the circle with radius = {2}", x, y, radius);
        }
        else
        {
            Console.WriteLine("x = {0} and y = {1} are not within the circle with radius = {2}", x, y, radius);
        }
    }
}