using System;

namespace MyTools.Statistics
{
    public class CorrCoe
    {
        /// <summary>
        /// 计算两个数组的自相关系数
        /// </summary>
        /// <param name="Arr">待求数组</param>
        /// <param name="Hysteresis">滞后数</param>
        /// <param name="Length">数据长度</param>
        /// <returns></returns>
        public static double[] GetCorrCoe(double[] Arr, int Hysteresis, int Length)
        {
            int len = Arr.Length;
            double[] corrCoe = new double[len + 1 - Hysteresis - Length];//可得到的自相关系数的组数
            for (int i = 0; i < corrCoe.Length; i++)
            {
                double μ = NumAndNum.getAvarage(Arr);
                double var = 0;
                corrCoe[i] = 0;

                for (int k = 0; k < len; k++)
                    var += Math.Pow(Arr[k] - μ, 2);

                for (int j = 0; j < Length; j++)
                    corrCoe[i] += (Arr[j + i] - μ) * (Arr[Hysteresis + j + i] - μ) / var;
            }
            return corrCoe;
        }
        /// <summary>
        /// 计算等长数组的相关系数
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public static double ρ(double[] X, double[] Y)
        {
            double VarX = Number.Calculator.Var(X);
            double VarY = Number.Calculator.Var(Y);
            double CovXY = Cov(X, Y);
            return CovXY / Math.Sqrt(VarX * VarY);
        }
        public static double ρ(int[] X, int[] Y)
        {
            double[] DX = new double[X.Length];
            double[] DY = new double[Y.Length];
            for(int i = 0; i < X.Length; i++)
            {
                DX[i] = (double)X[i];
                DY[i] = (double)Y[i];
            }
            return ρ(DX, DY);
        }
        /// <summary>
        /// 计算协方差
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public static double Cov(double[] X, double[] Y)
        {
            double EX = Number.Calculator.Mean(X);
            double EY = Number.Calculator.Mean(Y);
            double EXY = CalEXY(X, Y);
            return EXY - EX * EY;
        }
        private static double CalEXY(double[] X, double[] Y)
        {
            double[] XY = new double[X.Length];
            for (int i = 0; i < XY.Length; i++)
                XY[i] = X[i] * X[i];
            double EXY = Number.Calculator.Mean(XY);
            return EXY;
        }
    }
}
