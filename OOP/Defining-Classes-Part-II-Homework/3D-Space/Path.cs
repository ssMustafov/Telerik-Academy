using System;
using System.Collections.Generic;

namespace _3D_Space
{
    public class Path
    {
        private List<Point3D> path = new List<Point3D>();

        public Path(params Point3D[] point)
        {
            for (int i = 0; i < point.Length; i++)
            {
                this.path.Add(point[i]);
            }
        }

        internal List<Point3D> Path3D
        {
            get { return this.path; }
        }

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }
    }
}
