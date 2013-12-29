using System;

class WithinCircleOutOfRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        // Circle coordinates
        double cX = x - 1;
        double cY = y - 1;
        double cRadius = 3;

        if (((cX * cX) + (cY * cY)) <= (cRadius * cRadius))
        {
            Console.WriteLine("The coordinates are within teh circle");
        }
        else
        {
            Console.WriteLine("The coordinates are not within teh circle");
        }

        // Rectangle coordinates
        double rHeight = 2;
        double rWidth = 6;
        double topY = 0 + (rHeight / 2);
        double rightX = 0 + (rWidth / 2);
        double bottomY = 0 - (rHeight / 2);
        double leftX = 0 - (rWidth / 2);
        double rectPointX = cX - (-1); // = x + 1
        double rectPointY = cY - 1;

        Console.WriteLine("Rectangle coordinates: Top Y: {0} Right X: {1} Bottom Y: {2} Left X: {3}", topY, rightX, bottomY, leftX);

        if ((rectPointY < topY) && (rectPointY > bottomY) && (rectPointX < rightX) && (rectPointX > leftX))
        {
            Console.WriteLine("The coordinates are within the rectangle.");
        }
        else
        {
            Console.WriteLine("The coordinates are not within the rectangle.");
        }
    }
}