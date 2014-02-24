using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3D_Space
{
    public static class PathStorage
    {
        public static Path LoadPathFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new ArgumentException("The file does not exists.");
            }

            if (fileName == "")
            {
                throw new ArgumentException("The file name is empty.");
            }

            StreamReader reader = new StreamReader(fileName);

            Path loadPaths = new Path();
            
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] coordinates = line.Split(new char[] {' ', ',', '[', ']', '{', '}'}, StringSplitOptions.RemoveEmptyEntries);

                    Point3D point = new Point3D(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(coordinates[2]));
                    loadPaths.AddPoint(point);

                    line = reader.ReadLine();
                }
            }

            return loadPaths;
        }

        public static void SavePathToFile(string fileName, Path path)
        {
            if (fileName == "")
            {
                throw new ArgumentException("The file name is empty.");
            }

            if (path == null)
            {
                throw new ArgumentException("The path is empty.");
            }

            StreamWriter writer = new StreamWriter(fileName);

            using (writer)
            {
                for (int i = 0; i < path.Path3D.Count; i++)
                {
                    writer.WriteLine(path.Path3D[i]);
                }
            }
        }
    }
}
