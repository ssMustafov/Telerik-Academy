using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3D_Space
{
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;

        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D PointO
        {
            get { return pointO; }
        }
        
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public int Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            return String.Format("[{0},{1},{2}]", this.x, this.y, this.z);
        }
    }
}