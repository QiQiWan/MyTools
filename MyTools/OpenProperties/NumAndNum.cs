using System;

namespace MyTools
{
    /// <summary>
    /// 简单的数字方法库
    /// </summary>
    public class NumAndNum
    {
        /// <summary>
        /// 判断一个数是否互质
        /// </summary>
        /// <param name="a">第一个数</param>
        /// <param name="b">第二个数</param>
        /// <returns></returns>
        public static bool isPrime(int a, int b)
        {
            if (a == 0 || b == 0) return false;
            if (a < b) { int t = a; a = b; b = t; }
            if (maxCommonFactor(a, b) != 1) return false;
            return true;
        }
        /// <summary>
        /// 计算两个数的最大公约数
        /// </summary>
        /// <param name="a">较大的数</param>
        /// <param name="b">较小的数</param>
        /// <returns></returns>
        public static int maxCommonFactor(int a, int b)
        {
            if (a % b == 0) return b;
            else return maxCommonFactor(b, a % b);
        }
        /// <summary>
        /// 返回数组的中位数
        /// </summary>
        /// <param name="a">传入的数组</param>
        /// <returns>中位数</returns>
        public static double getMedium(double[] a)
        {
            a = sortDouble(a, true);
            int n = a.Length;
            if (n % 2 == 0)
                return (a[n/2] + a[n/2 + 1]) / 2.0;
            else
                return a[(n + 1) / 2];
        }
        /// <summary>
        /// 返回整形数组的平均值
        /// </summary>
        /// <param name="a">传入的数组</param>
        /// <returns>中位数</returns>
        public static double getMedium(int[] a)
        {
            a = sortDouble(a, true);
            int n = a.Length;
            if (n % 2 == 0)
                return (a[n / 2] + a[n / 2 + 1]) / 2.0;
            else
                return a[(n + 1) / 2];
        }
        /// <summary>
        /// 对实型数组冒泡排序
        /// </summary>
        /// <param name="a">传入数组</param>
        /// <param name="order">是否逆序</param>
        /// <returns>排序后的数组</returns>
        public static double[] sortDouble(double[] a, bool order)
        {
            if (order)
                for(int i = 0, len = a.Length; i < len; i++)
                {
                    for(int j = i; j < len; j++)
                    {
                        if (a[i] > a[j])
                        {
                            double t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
                    }
                }
            else
                for (int i = 0, len = a.Length; i < len; i++)
                {
                    for (int j = i; j < len; j++)
                    {
                        if (a[i] < a[j])
                        {
                            double t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
                    }
                }
            return a;
        }
        /// <summary>
        /// 对整形数组冒泡排序
        /// </summary>
        /// <param name="a">传入数组</param>
        /// <param name="order">是否逆序</param>
        /// <returns>排序后的数组</returns>
        public static int[] sortDouble(int[] a, bool order)
        {
            if (order)
                for (int i = 0, len = a.Length; i < len; i++)
                {
                    for (int j = i; j < len; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
                    }
                }
            else
                for (int i = 0, len = a.Length; i < len; i++)
                {
                    for (int j = i; j < len; j++)
                    {
                        if (a[i] < a[j])
                        {
                            int t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
                    }
                }
            return a;
        }
        public static double getAvarage(double[] a) => getSum(a) / a.Length;
        public static double getAvarage(int[] a) => (double)getSum(a) / a.Length;
        #region 返回数组总和
        public static double getSum(double[] a)
        {
            double sum = 0;
            for(int i = a.Length - 1; i >= 0; i--)
                sum += a[i];
            return sum;
        }
        public static int getSum(int[] a)
        {
            int sum = 0;
            for (int i = a.Length - 1; i >= 0; i--)
                sum += a[i];
            return sum;
        }
        #endregion
        #region 返回数组的方差
        /// <summary>
        /// 返回数组的方差
        /// </summary>
        /// <param name="a">传入的数组</param>
        /// <returns>方差</returns>
        public static double getVariance(double[] a)
        {
            double ba = getAvarage(a);
            double sum = 0;
            for (int i = a.Length - 1; i >= 0; i--)
                sum += Math.Pow(a[i] - ba, 2);
            return sum / a.Length;
        }
        /// <summary>
        /// 返回数组的方差
        /// </summary>
        /// <param name="a">传入的数组</param>
        /// <returns>方差</returns>
        public static double getVariance(int[] a)
        {
            double ba = getAvarage(a);
            double sum = 0;
            for (int i = a.Length - 1; i >= 0; i--)
                sum += Math.Pow((double)a[i] - ba, 2);
            return sum / a.Length;
        }
        #endregion

        //判断一个数是否在对应区间
        public static bool IsIn<T>(T num, T bottom, T top)
        {
            double Num, Bottom, Top;
            if (!Double.TryParse(num.ToString(), out Num)) return false;
            if (!Double.TryParse(bottom.ToString(), out Bottom)) return false;
            if (!Double.TryParse(top.ToString(), out Top)) return false;
            if (Num >= Top || Num < Bottom) return false;
            return true;
        }
    }
}
