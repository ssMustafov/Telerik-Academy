using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3D_Space
{
    static class Distance
    {
        public static int DistanceBetweenTwoPoints(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            int xd = x2 - x1;
            int yd = y2 - y1;
            int zd = z2 - z1;
            int part = xd * xd + yd * yd + zd * zd;

            return SqrtPrecalculated.GetSqrt(part);
        }
    }
}
