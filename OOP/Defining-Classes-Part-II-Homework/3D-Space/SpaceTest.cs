using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3D_Space
{
    class SpaceTest
    {
        static void Main()
        {
            Point3D point = new Point3D(3, 5, 2);

            Console.WriteLine(point.ToString());

            point.Y = -3;

            Point3D point2 = new Point3D(0, 4, -4);

            Console.WriteLine(point);
            Console.WriteLine(point2);
            Console.WriteLine(Point3D.PointO);

            Console.WriteLine(Distance.DistanceBetweenTwoPoints(point.X, point.Y, point.Z, point2.X, point2.Y, point2.Z));

            Path path = PathStorage.LoadPathFromFile("load.txt");
            Console.WriteLine("Paths:");
            for (int i = 0; i < path.Path3D.Count; i++)
            {
                Console.WriteLine(path.Path3D[i]);
            }

            PathStorage.SavePathToFile("save.txt", path);
        }
    }
}
