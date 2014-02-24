using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class MatrixTest
    {
        static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(2, 3);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Matrix<int> matrix2 = new Matrix<int>(3, 2);

            for (int i = 0; i < matrix2.Rows; i++)
            {
                for (int j = 0; j < matrix2.Cols; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Matrix<int> res = matrix * matrix2;

            for (int i = 0; i < res.Rows; i++)
            {
                for (int j = 0; j < res.Cols; j++)
                {
                    Console.Write("{0} ", res[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
