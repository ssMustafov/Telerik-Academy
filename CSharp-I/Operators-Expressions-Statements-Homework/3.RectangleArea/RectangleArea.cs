using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        Console.WriteLine("Rectangle's area is: {0}", area);
    }
}