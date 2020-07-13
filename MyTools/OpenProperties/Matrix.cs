using System;

namespace MyTools.OpenProperties
{
    /// <summary>
    /// 简单的矩阵运算库
    /// </summary>
    static class Matrix
    {
        /// <summary>
        /// 返回矩阵点乘的结果
        /// </summary>
        /// <param name="x">矩阵1</param>
        /// <param name="y">矩阵2</param>
        /// <returns></returns>
        public static double dot(double[] x, double[] y)
        {
            double s = 0;
            for (int i = 0, len = x.Length; i < len; i++)
            {
                s += x[i] * y[i];
            }
            return s;
        }
        /// <summary>
        /// 返回矩阵点乘的结果
        /// </summary>
        /// <param name="x">矩阵1</param>
        /// <param name="y">矩阵2</param>
        /// <returns></returns>
        public static int dot(int[] x, int[] y)
        {
            int s = 0;
            for (int i = 0, len = x.Length; i < len; i++)
            {
                s += x[i] * y[i];
            }
            return s;
        }
        /// <summary>
        /// 返回两个矩阵的叉乘
        /// </summary>
        /// <param name="a">矩阵1</param>
        /// <param name="b">矩阵2</param>
        /// <returns></returns>
        public static double[][] mult(double[][] a, double[][] b)
        {
            if (a[0].Length != b.Length || a.Length != b[0].Length) throw new Exception("传入矩阵不符合要求");
            int row = a.Length, col = b[0].Length;
            double[][] c = new double[row][];
            for (int i = 0; i < row; i++)
                c[i] = new double[col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    c[i][j] = 0;
                    for (int m = b.Length - 1; m >= 0; m--)
                        c[i][j] += a[i][m] * b[m][j];
                }
            }
            return c;
        }
        /// <summary>
        /// 返回两个矩阵的叉乘
        /// </summary>
        /// <param name="a">矩阵1</param>
        /// <param name="b">矩阵2</param>
        /// <returns></returns>
        public static int[][] mult(int[][] a, int[][] b)
        {
            if (a[0].Length != b.Length || a.Length != b[0].Length) throw new Exception("传入矩阵不符合要求");
            int row = a.Length, col = b[0].Length;
            int[][] c = new int[row][];
            for (int i = 0; i < row; i++)
                c[i] = new int[col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    c[i][j] = 0;
                    for (int m = b.Length - 1; m >= 0; m--)
                        c[i][j] += a[i][m] * b[m][j];
                }
            }
            return c;
        }
        /// <summary>
        /// 返回转置的矩阵
        /// </summary>
        /// <param name="a">需要转置的矩阵</param>
        /// <returns></returns>
        public static double[][] transpose(double[][] a)
        {
            int row = a.Length, col = a[0].Length;
            double[][] b = new double[col][];
            for (int i = 0; i < col; i++)
                b[i] = new double[row];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    b[j][i] = a[i][j];
            return b;
        }
        /// <summary>
        /// 返回矩阵乘向量的积
        /// </summary>
        /// <param name="a">矩阵</param>
        /// <param name="x">向量</param>
        /// <returns>新矩阵</returns>
        public static double[] mult(double[][] a, double[] x)
        {
            double[] newM = new double[a.Length];
            for (int i = 0, lenA = a.Length; i < lenA; i++)
            {
                newM[i] = 0;
                for (int j = 0, lenX = x.Length; j < lenX; j++)
                {
                    newM[i] += a[i][j] * x[j];
                }
            }
            return newM;
        }
        /// <summary>
        /// 返回向量乘矩阵的积
        /// </summary>
        /// <param name="x">向量</param>
        /// <param name="a">矩阵</param>
        /// <returns>新矩阵</returns>
        public static double[] mult(double[] x, double[][] a)
        {
            double[] newM = new double[x.Length];
            for (int i = 0, lenX = x.Length; i < lenX; i++)
            {
                newM[i] = 0;
                for (int j = 0, lenA = a.Length; j < lenA; j++)
                {
                    newM[i] += x[i] * a[j][i];
                }
            }
            return newM;
        }
        public static double[][] Inverse(double[][] a) => a;
    }

}
