using System;

class PrintPerimeterAndAreaOfCircle
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * (radius * radius);

        Console.WriteLine("The circle's perimeter is: {0}", perimeter);
        Console.WriteLine("The circle's area is: {0}", area);
    }
}