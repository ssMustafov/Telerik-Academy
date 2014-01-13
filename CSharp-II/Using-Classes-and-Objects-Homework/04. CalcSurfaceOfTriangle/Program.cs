// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcSurfaceOfTriangle
{
    class Program
    {
        static double CalcTriangleSurface(double side, double altitude)
        {
            return (side * altitude) / 2;
        }

        static double CalcTriangleSurface(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double areaWithoutRoot = semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC);
            double area = Math.Sqrt(areaWithoutRoot);

            return area;
        }

        static double CalcTriangleSurface(double sideOne, double sideTwo, float angle)
        {
            double area = ((sideOne * sideTwo) / 2) * Math.Sin(angle);

            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the surface of a triangle:");
            
            char codeOp;
            do
            {
                Console.WriteLine("\t0 - exit");
                Console.WriteLine("\t1 - with given side and an altitude to it;");
                Console.WriteLine("\t2 - with given three sides;");
                Console.WriteLine("\t3 - with given two sides and an angle between them.");
                Console.Write("Enter operation code: ");
                codeOp = char.Parse(Console.ReadLine());

                switch (codeOp)
                {
                    case '0': break;
                    case '1':
                            Console.Write("Enter side: ");
                            double side = double.Parse(Console.ReadLine());

                            Console.Write("Enter altitude: ");
                            double altitude = double.Parse(Console.ReadLine());

                            Console.WriteLine("The triangle surface is: {0} cm^2", CalcTriangleSurface(side, altitude));
                        break;
                    case '2':
                            Console.Write("Enter side A: ");
                            double sideA = double.Parse(Console.ReadLine());

                            Console.Write("Enter side B: ");
                            double sideB = double.Parse(Console.ReadLine());

                            Console.Write("Enter side C: ");
                            double sideC = double.Parse(Console.ReadLine());

                            Console.WriteLine("The triangle surface is: {0} cm^2", CalcTriangleSurface(sideA, sideB, sideC));
                        break;
                    case '3':
                            Console.Write("Enter first side: ");
                            double sideOne = double.Parse(Console.ReadLine());

                            Console.Write("Enter second side: ");
                            double sideTwo = double.Parse(Console.ReadLine());

                            Console.Write("Enter angle: ");
                            float angle = float.Parse(Console.ReadLine());

                            Console.WriteLine("The triangle surface is: {0} cm^2", CalcTriangleSurface(sideOne, sideTwo, angle));
                        break;
                    default: Console.WriteLine("Wrong operation code!"); break;
                }
            } while (codeOp != '0');
        }
    }
}
