using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3D_Space
{
    public static class SqrtPrecalculated
    {
        private const int MaxValues = 10000;

        private static int[] sqrtValues;

        static SqrtPrecalculated()
        {
            sqrtValues = new int[MaxValues];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int) Math.Sqrt(i);
            }
        }

        public static int GetSqrt(int value)
        {
            return sqrtValues[value];
        }
    }
}
