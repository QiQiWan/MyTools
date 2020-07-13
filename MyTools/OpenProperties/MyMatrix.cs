using System;

namespace MyTools.OpenProperties
{
    public class MyMatrix
    {
        //构造矩阵类型
        // the number of cols
        public readonly int Length;
        // the number of rows
        public readonly int Height;

        public double[][] matrixCore;

        /// <summary>
        /// 初始化0矩阵
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Length"></param>
        public MyMatrix(int Height, int Length)
        {
            this.Length = Length;
            this.Height = Height;
            matrixCore = new double[Height][];
            // 初始化0矩阵
            for (int i = 0; i < Height; i++)
            {
                double[] temp = new double[Length];
                for (int j = 0; j < Length; j++)
                {
                    temp[j] = 0;
                }
                matrixCore[i] = temp;
            }
        }

        public MyMatrix(double[,] matrixObj)
        {
            this.Height = matrixObj.GetLength(0);
            this.Length = matrixObj.GetLength(1);
            matrixCore = new double[Height][];
            for (int i = 0; i < Height; i++)
            {
                double[] temp = new double[Length];
                for (int j = 0; j < Length; j++)
                {
                    temp[j] = matrixObj[i, j];
                }
                matrixCore[i] = temp;
            }
        }

        /// <summary>
        /// 从交错数组中初始化矩阵
        /// </summary>
        /// <param name="matrix"></param>
        public MyMatrix(double[][] matrix)
        {
            this.matrixCore = matrix;
            this.Height = matrix.Length;
            this.Length = matrix[0].Length;
        }

        public MyMatrix(double[][] matrix, int width, int height)
        {
            this.Height = height;
            this.Length = width;
            this.matrixCore = matrix;
        }


        public bool Equals(MyMatrix matrixObj)
        {
            if (this.Height != matrixObj.Height || this.Length != matrixObj.Length)
                return false;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (matrixCore[i][j] != matrixObj.matrixCore[i][j])
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string str = "";
            string[] strs = ToStringArr();
            for (int i = 0; i < strs.Length; i++)
            {
                str += strs[i] + Environment.NewLine;
            }
            return str;
        }
        public string[] ToStringArr()
        {
            string[] strs = new string[Height];
            for (int i = 0; i < Height; i++)
            {
                strs[i] = "";
                for (int j = 0; j < Length; j++)
                {
                    if (j != Length - 1)
                        strs[i] += matrixCore[i][j].ToString() + ",";
                    else
                        strs[i] += matrixCore[i][j].ToString();
                }
            }
            return strs;
        }
    }
}
