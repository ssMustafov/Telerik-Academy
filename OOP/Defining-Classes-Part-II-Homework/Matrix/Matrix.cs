using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class Matrix<T>
        where T : struct, IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
        }
        
        public int Cols
        {
            get { return this.cols; }
        }

        public T this[int row, int col]
        {   
            get
            {
                if (row > this.rows || row < 0 || col > this.cols || col < 0)
                {
                    throw new ArgumentException("Index was out of range");
                }

                return this.matrix[row, col];
            }
            set
            {
                if (row > this.rows || row < 0 || col > this.cols || col < 0)
                {
                    throw new ArgumentException("Index was out of range");
                }

                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.rows != second.rows || first.cols != second.cols)
            {
                throw new ArgumentException("The matrices are not with equal size.");
            }

            Matrix<T> newMatrix = new Matrix<T>(first.rows, first.cols);

            for (int row = 0; row < first.rows; row++)
            {
                for (int col = 0; col < first.cols; col++)
                {
                    newMatrix[row, col] = first[row, col] + (dynamic)second[row, col];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.rows != second.rows || first.cols != second.cols)
            {
                throw new ArgumentException("The matrices are not with equal size.");
            }

            Matrix<T> newMatrix = new Matrix<T>(first.rows, first.cols);

            for (int row = 0; row < first.rows; row++)
            {
                for (int col = 0; col < first.cols; col++)
                {
                    newMatrix[row, col] = first[row, col] - (dynamic)second[row, col];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.cols != second.rows)
            {
                throw new ArgumentException("The rows size must be equal to cols size");
            }

            Matrix<T> newMatrix = new Matrix<T>(first.rows, second.cols);

            for (int row = 0; row < first.rows; row++)
            {
                for (int col = 0; col < second.cols; col++)
                {
                    for (int i = 0; i < first.cols; i++)
                    {
                        newMatrix[row, col] += first[row, i] * (dynamic)second[i, col];
                    }
                }
            }

            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (matrix[row, col].CompareTo(0) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (matrix[row, col].CompareTo(0) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
